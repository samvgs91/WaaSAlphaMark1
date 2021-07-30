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

namespace WaaSAlphaMark1
{
    public partial class FirstViewForm : Form {

        String userId = "abcdeid";
        SqlConnection sqlCon = new SqlConnection("Data Source=dccsrveu2taller03.database.windows.net;Initial Catalog=dccadbeu2taller03;Persist Security Info=True;User ID=adminusr;Password=@psstaller01");
        DataSet dsTableList = new DataSet("TableList");

   

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

        private void dgvWarehouseTableList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvWarehouseTableList.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvWarehouseTableList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvWarehouseTableList.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Table Name"].Value);
                EditTable(cellValue);
            }
        }
    }
}
