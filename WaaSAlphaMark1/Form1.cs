using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;


using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Auth;
using Microsoft.Azure.Storage.Blob;


using Microsoft.Rest;
using Microsoft.Azure.Management.DataFactory;
using Microsoft.Azure.Management.DataFactory.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;


namespace WaaSAlphaMark1
{



    public partial class Form1 : Form
    {

        private FirstViewForm CallingForm = null;
        public Form1(String _param, String _tableId,FirstViewForm callingForm) : this()
        {
            this.CallingForm = callingForm;

            if (_param == "EDIT")
            {
                this.param = _param;
                this.tableName = _tableId;
                FillDataFromTable(tableName);
            }
        }


        DataGridViewComboBoxColumn modelColumnTypeCombo = new DataGridViewComboBoxColumn();
        
        SqlConnection sqlCon = new SqlConnection("Data Source=dccsrveu2taller03.database.windows.net;Initial Catalog=dccadbeu2taller03;Persist Security Info=True;User ID=adminusr;Password=@psstaller01");
        DataTable dtInsert = new DataTable();
        DataTable dtEdited = new DataTable();
        String blobPath = "data/excel";
        String storageName = "storpocd01";
        String userId = "abcdeid";
        String tableName = "";
        String containerName = "waas-data";
        String storageKey = "6huuCa1oNMFOazxl+qJhRMlxsvoupH1tX66S0SFoy+k5mwBe+f/GAnrLZGTOsySSGmk2F6tYdhpD/UbhbFuf9w==";

        string tenantID = "aa0fda5b-fa1f-4585-a8e7-3b8dfc42312e";
        string applicationId = "18dfd4fb-bb0f-4d8a-9cf3-2318221be34e";
        string authenticationKey = "FTPjkbZU_628U-ehgq4Lp-c8GOY.74d291";
        string subscriptionId = "433bd50e-8953-4b73-87c8-382037395d88";
        string resourceGroup = "gr-waas-poc-ea2-01";
        string region = "East US 2";
        string dataFactoryName = "adfpocd01";
        string pipelineName = "WaaSDataLoader";

        string conn = string.Empty;
        string filePath = string.Empty;
        string fileName = string.Empty;
        string param = "";
        
        //string tableId = "";

        DataTable dtexcel = new DataTable();
        DataTable dt = new DataTable("Metadata");

        public Form1()
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.CallingForm != null)
                this.CallingForm.Close();
            (new FirstViewForm()).Show();
        }

        private void FillDataFromTable(String tableId)
        {
            txtTableName.Enabled = false;
            txtTableName.Text = tableId;
            btnLoadMetadata.Visible = false;

            GetTableMetadata(userId, tableId);
            GetBlobStatus(userId, tableId);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private String GetBlobId(String fileName,String userId)
        {
            DataTable dtBlogTable = new DataTable();

            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("[WaaS].[USP_WAAS_GET_BLOBID_BY_FILENAME]", sqlCon);
            cmd.Parameters.AddWithValue("@fileName", fileName); // passing Datatable 
            cmd.Parameters.AddWithValue("@userId", userId); // passing Datatable 
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dtBlogTable);
            sqlCon.Close();
            String blobId = dtBlogTable.Rows[0].Field<Guid>("BlobPathId").ToString();
                
            return blobId;
        }

        private void LaunchADFProcess(String tblName, String fleName)
        {

                String blobId = GetBlobId(fleName, userId);

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
                    //{ tableName, fileName },
                    { "blobId", blobId},
                    { "userId", userId}
                    //{ "outputPath", outputBlobPath }
                };
                CreateRunResponse runResponse = client.Pipelines.CreateRunWithHttpMessagesAsync(
                    resourceGroup, dataFactoryName, pipelineName, parameters: parameters
                ).Result.Body;
                Console.WriteLine("Pipeline run ID: " + runResponse.RunId);

                var runId = runResponse.RunId;

                Console.WriteLine("Checking pipeline run status...");
                PipelineRun pipelineRun;

                while (true)
                {
                    pipelineRun =  client.PipelineRuns.Get(resourceGroup, dataFactoryName, runId);
                    Console.WriteLine("Status: " + pipelineRun.Status);
                    if (pipelineRun.Status == "InProgress" || pipelineRun.Status == "Queued")
                        System.Threading.Thread.Sleep(15000);
                    else
                        break;
                }


                MessageBox.Show("ADF Launched Successfully", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private Boolean CompareDataTables(DataTable dt1, DataTable dt2)
        {

            String ColumnsDt1 = "";
            String ColumnsDt2 = "";
            Boolean status = false;

            foreach (DataColumn column in dt1.Columns)
            {
                ColumnsDt1 += column.ColumnName;
            }

            foreach (DataColumn column in dt2.Columns)
            {
                ColumnsDt2 += column.ColumnName;
            }

            if (ColumnsDt1 == ColumnsDt2)
            {
                status = true;
            }
            return status;
        }


        private void LoadAditionalFile()
        {
            string fileExt = string.Empty;

            OpenFileDialog file = new OpenFileDialog();//open dialog to choose file
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)//if there is a file choosen by the user
            {
                filePath = file.FileName;//get the path of the file
                fileName = file.SafeFileName;
                fileExt = Path.GetExtension(filePath);//get the file extension
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {

                        //Upload the file and insert the record in the database
                        UploadFileByName(filePath, fileName);
                        DatasetBlobInsert(userId, tableName, storageName, containerName, fileName);
                        FillDataFromTable(tableName);
                        //LaunchADFProcess();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please choose .xls or .xlsx file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);//custom messageBox to show error
                }
            }
        }

        private void LoadNewMetadataFile_FirstTime()
        {
            string fileExt = string.Empty;

            OpenFileDialog file = new OpenFileDialog();//open dialog to choose file
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)//if there is a file choosen by the user
            {
                filePath = file.FileName;//get the path of the file
                fileName = file.SafeFileName;
                fileExt = Path.GetExtension(filePath);//get the file extension
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        DataTable dtExcel = new DataTable();
                        dtExcel = ReadExcel(filePath, fileExt);//read excel file
                        dataGridView1.Visible = true;
                        dataGridView1.DataSource = dtExcel;
                        dtInsert = dtExcel;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please choose .xls or .xlsx file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);//custom messageBox to show error
                }
            }
        }





        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (param == "EDIT")
            {
                LoadAditionalFile();
            }
            else {
                LoadNewMetadataFile_FirstTime();
            }
            
        }

        public DataTable ReadExcel(string fileName, string fileExt)
        {


            if (fileExt.CompareTo(".xls") == 0)//compare the extension of the file
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';";//for below excel 2007
            else
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1';";//for above excel 2007
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [Sheet1$]", con);//here we read data from sheet1
                    oleAdpt.Fill(dtexcel);//fill excel data into dataTable

                    //dt.Columns.Add("UserId", typeof(string));
                    //dt.Columns.Add("TableName", typeof(string));
                    dt.Columns.Add("SourceColumn", typeof(string));
                    dt.Columns.Add("ColumnName", typeof(string));
                    dt.Columns.Add("ColumnDataType", typeof(string));
                    dt.Columns.Add("ColumnModelType", typeof(string));
                    dt.Columns.Add("ColumnMetricType", typeof(string));

                    int contador = 1;
                    foreach (DataColumn column in dtexcel.Columns)
                    {
                        dt.Rows.Add(contador, column.ColumnName.ToString(), column.DataType.ToString().Replace("System.", ""),"Attribute","");
                        contador += 1;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            //return dtexcel;
            return dt;
        }

        private void DatasetInsert(DataTable dt,String userId, String tableName)
        {   
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("[WaaS].[USP_WAAS_METADATAINSERT]", sqlCon);
            cmd.Parameters.AddWithValue("@UserDefineTable", dt); // passing Datatable 
            cmd.Parameters.AddWithValue("@tableName",tableName); // passing Datatable 
            cmd.Parameters.AddWithValue("@userId", userId); // passing Datatable 
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            sqlCon.Close();
        }

        private void GenerateScripts(String userId, String tableName)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("[WaaS].[USP_WAAS_GENERATE_SCRIPTS]", sqlCon);
            cmd.Parameters.AddWithValue("@TableName", tableName); // passing Datatable 
            cmd.Parameters.AddWithValue("@UserId", userId); // passing Datatable 
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            sqlCon.Close();
        }


        private void DeployTable(String userId, String tableName)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("[WaaS].[USP_WAAS_DEPLOY_SCRIPTS]", sqlCon);
            cmd.Parameters.AddWithValue("@TableName", tableName); // passing Datatable 
            cmd.Parameters.AddWithValue("@UserId", userId); // passing Datatable 
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            sqlCon.Close();
        }


        private void ProcessModel(String userId, String tableName)
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
                    { "userId", userId}
                };
            CreateRunResponse runResponse = client.Pipelines.CreateRunWithHttpMessagesAsync(
                resourceGroup, dataFactoryName, "WaaSModelProcess", parameters: parameters
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


        private void DeployModel(String userId, String tableName)
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
                    { "userId", userId}
                };
            CreateRunResponse runResponse = client.Pipelines.CreateRunWithHttpMessagesAsync(
                resourceGroup, dataFactoryName, "WaaSModelDeploy", parameters: parameters
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


        private DataTable GetListComboxModelAggFunc() 
        {
            DataTable dtModelMetricFuncType = new DataTable();
            dtModelMetricFuncType.Columns.Add("ColMetricFuncType", typeof(string));

            dtModelMetricFuncType.Rows.Add("SUM");
            dtModelMetricFuncType.Rows.Add("COUNT");
            dtModelMetricFuncType.Rows.Add("AVERAGE");
            dtModelMetricFuncType.Rows.Add("DISTINCTCOUNT");

            return dtModelMetricFuncType;
        }
        
        private DataTable GetListComboxModelColumnType()
        {
            DataTable dtModelColumnType = new DataTable();
            dtModelColumnType.Columns.Add("ModelColumnType", typeof(string));

            dtModelColumnType.Rows.Add("Attribute");
            dtModelColumnType.Rows.Add("Metric");

            return dtModelColumnType;
        }

        private void GetTableMetadata(String userId, String tableName)
        {

            DataTable dtMetadata = new DataTable();

            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("[WaaS].[USP_WAAS_GET_METADATAINSERT]", sqlCon);
            cmd.Parameters.AddWithValue("@TableName", tableName); // passing Datatable 
            cmd.Parameters.AddWithValue("@UserId", userId); // passing Datatable 
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dtMetadata);

            sqlCon.Close();

            dataGridView1.Visible = true;
            dataGridView1.DataSource = dtMetadata;
            dataGridView1.ReadOnly = true;
        }


        private void GetBlobStatus(String userId, String tableName)
        {

            DataTable dtMetadata = new DataTable();

            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("[WaaS].[USP_WAAS_GET_BLOB_STATUS]", sqlCon);
            cmd.Parameters.AddWithValue("@TableName", tableName); // passing Datatable 
            cmd.Parameters.AddWithValue("@UserId", userId); // passing Datatable 
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dtMetadata);

            sqlCon.Close();
            dgvFiles.Visible = true;
            dgvFiles.DataSource = dtMetadata;
            dgvFiles.ReadOnly = true;
        }



        private void btnLoadMetadata_Click(object sender, EventArgs e)
        {

            if (dtInsert.Rows.Count > 0 && txtTableName.Text.Length>0)
            {
                tableName = txtTableName.Text;
                dtEdited = dataGridView1.DataSource as DataTable;
                DatasetInsert(dtEdited,userId, tableName);
                GenerateScripts(userId, tableName);
                DeployTable(userId, tableName);
                UploadFileByName(filePath, fileName);
                DatasetBlobInsert(userId, tableName, storageName, containerName, fileName);

                //userId, userTableName, storageName, blobPath, fileName
                //LoadFileIntoStorage(userId, tableName);


                //txtTableName.Text = "";
                //dataGridView1.DataSource = null;
                //dataGridView1.Refresh();

                FillDataFromTable(tableName);

                MessageBox.Show("Table Created", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);//custom messageBox to show error
            }
            else
            {
                MessageBox.Show("Please load an .xls or .xlsx before loading metadata or table does not have name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);//custom messageBox to show error
            }


        }

        private void LoadFileIntoStorage(string userId, string userTableName)
        {
            string filePath = string.Empty;
            string fileExt = string.Empty;
            string fileName = string.Empty;
            OpenFileDialog file = new OpenFileDialog();//open dialog to choose file
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)//if there is a file choosen by the user
            {
                filePath = file.FileName;//get the path of the file
                fileName = file.SafeFileName;
                fileExt = Path.GetExtension(filePath);//get the file extension

                UploadFileByName(filePath, fileName);
                DatasetBlobInsert(userId, userTableName, storageName, blobPath, fileName);

                MessageBox.Show("File: " + fileName + " from Path: " + filePath + " was loaded", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);//custom messageBox to show error
            }
        }

        public void DatasetBlobInsert(string userId, string userTableName, string storageName, string path, string fileName)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("[WaaS].[USP_WAAS_BLOBPATH_INSERT]", sqlCon);
            cmd.Parameters.AddWithValue("@UserId", userId); // passing UserIde 
            cmd.Parameters.AddWithValue("@UserTableName", userTableName); // passing UserTableName 
            cmd.Parameters.AddWithValue("@StorageAccount", storageName); // passing StorageAccountName 
            cmd.Parameters.AddWithValue("@Path", path); // passing Path
            cmd.Parameters.AddWithValue("@FileName", fileName); // passing fileName
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            sqlCon.Close();
        }

        private void UploadFileByName(string path, string fileName)
        {
            StorageCredentials credentials = new StorageCredentials(storageName, storageKey);
            CloudStorageAccount storageAccount = new CloudStorageAccount(credentials, useHttps: true);
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer blobContainer = blobClient.GetContainerReference(containerName);
            //blobContainer.Create();
            CloudBlockBlob blob = blobContainer.GetBlockBlobReference(fileName);
            //blob.UploadFromFile("D:\\A Peruvian Software Company\\WaaS 1 Project\\Sample Data\\DataExample.xlsx");
            blob.Properties.ContentType = "data/excel";
            blob.UploadFromFile(path);
        }

        private void DeleteBlobFileByName(string path, string fileName)
        {
            StorageCredentials credentials = new StorageCredentials(storageName, storageKey);
            CloudStorageAccount storageAccount = new CloudStorageAccount(credentials, useHttps: true);
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer blobContainer = blobClient.GetContainerReference(containerName);
            //blobContainer.Create();
            CloudBlockBlob blob = blobContainer.GetBlockBlobReference(fileName);
            //blob.UploadFromFile("D:\\A Peruvian Software Company\\WaaS 1 Project\\Sample Data\\DataExample.xlsx");
            blob.Properties.ContentType = "data/excel";
            blob.DeleteIfExists();
        }

        public void DeleteFileDataFromTable(string userId, string userTableName, string fileName)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("[WaaS].[USP_WAAS_DELETE_FILEDATA]", sqlCon);
            cmd.Parameters.AddWithValue("@UserId", userId); // passing UserIde 
            cmd.Parameters.AddWithValue("@TableId", userTableName); // passing UserTableName 
            cmd.Parameters.AddWithValue("@FileName", fileName); // passing fileName
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            sqlCon.Close();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (dgvFiles.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvFiles.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvFiles.Rows[selectedrowindex];
                string dgvFileName = Convert.ToString(selectedRow.Cells["FileName"].Value);
                //EditTable(cellValue);
                LaunchADFProcess(tableName,dgvFileName);
                GetBlobStatus(userId, tableName);
            }
        }

        private void btnModelCreateUpdate_Click(object sender, EventArgs e)
        {
            DeployModel(this.userId, this.tableName);
        }

        private void btnModelProcess_Click(object sender, EventArgs e)
        {
            ProcessModel(this.userId, this.tableName);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1)
            {

                DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();

                //int selectedrowindex = dgvFiles.SelectedCells[e.].RowIndex;
                //DataGridViewRow selectedRow = dgvFiles.Rows[selectedrowindex];
                //string colTypeName = Convert.ToString(selectedRow.Cells["ColumnModelType"].Value);
                string colTypeName = "";

                if (e.ColumnIndex > 0)
                { 
                       colTypeName = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                }

                if (dataGridView1.Columns[e.ColumnIndex].Name.Contains("ColumnModelType"))
                {
                    dataGridView1[e.ColumnIndex, e.RowIndex] = comboBoxCell;
                    comboBoxCell.DataSource = GetListComboxModelColumnType();
                    comboBoxCell.ValueMember = "ModelColumnType";
                    comboBoxCell.DisplayMember = "ModelColumnType";
                } else
                if (dataGridView1.Columns[e.ColumnIndex].Name.Contains("ColumnMetricType") && colTypeName == "Metric")
                {
                    dataGridView1[e.ColumnIndex, e.RowIndex] = comboBoxCell;
                    comboBoxCell.DataSource = GetListComboxModelAggFunc();
                    comboBoxCell.ValueMember = "ColMetricFuncType";
                    comboBoxCell.DisplayMember = "ColMetricFuncType";
                }


            }
        }

        private void btnEliminarArchivo_Click(object sender, EventArgs e)
        {
            if (dgvFiles.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvFiles.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvFiles.Rows[selectedrowindex];
                string FileName = Convert.ToString(selectedRow.Cells["FileName"].Value);

                DeleteFileDataFromTable(this.userId, this.tableName, FileName);
                ProcessModel(this.userId, this.tableName);
                GetBlobStatus(this.userId, this.tableName);
            }
        }
    }
}
