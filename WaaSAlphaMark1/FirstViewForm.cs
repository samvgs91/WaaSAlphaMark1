using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


using Microsoft.Rest;
using Microsoft.Azure.Management.DataFactory;
using Microsoft.Azure.Management.DataFactory.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;


namespace WaaSAlphaMark1
{
    public partial class FirstViewForm : Form {

        String userId = "abcdeid";
        SqlConnection sqlCon = new SqlConnection("Data Source=dccsrveu2taller03.database.windows.net;Initial Catalog=dccadbeu2taller03;Persist Security Info=True;User ID=adminusr;Password=@psstaller01");
        DataSet dsTableList = new DataSet("TableList");

        string tenantID = "aa0fda5b-fa1f-4585-a8e7-3b8dfc42312e";
        string applicationId = "18dfd4fb-bb0f-4d8a-9cf3-2318221be34e";
        string authenticationKey = "FTPjkbZU_628U-ehgq4Lp-c8GOY.74d291";
        string subscriptionId = "433bd50e-8953-4b73-87c8-382037395d88";
        string resourceGroup = "gr-waas-poc-ea2-01";
        string dataFactoryName = "adfpocd01";

        public FirstViewForm()
        {
            InitializeComponent();
            //this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseFirstViewForm);
            GetTables(userId);
        }

        private void CloseFirstViewForm()
        {
            //this.Close();
            this.Hide();
            (new Form1()).Show();
            
        }

        private void EditTable(String tableId)
        {
            this.Hide();
            Form1 frm = new Form1("EDIT", tableId, this);
            frm.Show();
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {

            CloseFirstViewForm();
            //EditTable(tableId);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GetTables(String userId)
        {
            DataTable dtTableList = new DataTable();


            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("[WaaS].[USP_WAAS_GET_TABLES]", sqlCon);
            cmd.Parameters.AddWithValue("@UserId", userId); // passing Datatable 
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dtTableList);

            sqlCon.Close();
            dgvWarehouseTableList.Visible = true;
            dgvWarehouseTableList.DataSource = dtTableList;
            dgvWarehouseTableList.ReadOnly = true;

        }

        //private void dgvWarehouseTableList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        private void dgvWarehouseTableList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvWarehouseTableList.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvWarehouseTableList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvWarehouseTableList.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Table Name"].Value);
                EditTable(cellValue);
            }
        }


        private void DropTable(String TableName)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("[WaaS].[USP_WAAS_DROP_TABLE_CONF]", sqlCon);
            cmd.Parameters.AddWithValue("@TableName", TableName); // passing Datatable 
            cmd.Parameters.AddWithValue("@UserId", this.userId); // passing Datatable 
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            sqlCon.Close();

        }

        private void DropModel(String tableName)
        {
            var context = new AuthenticationContext("https://login.microsoftonline.com/" + tenantID);
            ClientCredential cc = new ClientCredential(applicationId, authenticationKey);
            AuthenticationResult result = context.AcquireTokenAsync(
                "https://management.azure.com/", cc).Result;
            ServiceClientCredentials cred = new TokenCredentials(result.AccessToken);
            var client = new DataFactoryManagementClient(cred)
            {
                SubscriptionId = subscriptionId
            };


            Console.WriteLine("Creating pipeline run...");
            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "tableid", tableName},
                    { "userId", this.userId}
                };
            CreateRunResponse runResponse = client.Pipelines.CreateRunWithHttpMessagesAsync(
                resourceGroup, dataFactoryName, "WaaSModelDrop", parameters: parameters
            ).Result.Body;
            Console.WriteLine("Pipeline run ID: " + runResponse.RunId);

            var runId = runResponse.RunId;

            Console.WriteLine("Checking pipeline run status...");
            PipelineRun pipelineRun;

            while (true)
            {
                pipelineRun = client.PipelineRuns.Get(resourceGroup, dataFactoryName, runId);
                Console.WriteLine("Status: " + pipelineRun.Status);
                if (pipelineRun.Status == "InProgress" || pipelineRun.Status == "Queued")
                    System.Threading.Thread.Sleep(15000);
                else
                    break;
            }


            MessageBox.Show("ADF SSAS Table in Model Launched Successfully", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnDropTable_Click(object sender, EventArgs e)
        {
            if (dgvWarehouseTableList.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvWarehouseTableList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvWarehouseTableList.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Table Name"].Value);
                DropModel(cellValue);
                DropTable(cellValue);
                GetTables(userId);
            }

        }
    }
}
