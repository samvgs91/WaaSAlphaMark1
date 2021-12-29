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
using WaaSDomain;
using WaaSEntities;

namespace WaaSAlphaMark1
{
    public partial class DatasetView : Form
    {

        private string UserId;
        private string DatasetId;
        private DatasetModel datasetModel;
        private Dataset ds;
        public event EventHandler ReturnToDatasets;

        public DatasetView(string userId,string datasetId)
        {
            this.UserId = userId;
            this.DatasetId = datasetId;
            datasetModel = new DatasetModel();
            ds = datasetModel.GetDataset(userId, datasetId);
            InitializeComponent();
            FillDatasetFiles();

            if (datasetId != null)
            {
                //this.lblDatasetName.Text = "Dataset > Demo >" + StartedFileId;
                this.lblDatasetName.Text =  ds.Name;
            }
        }

        private void ibtNewFile_Click(object sender, EventArgs e)
        {

        }

        private void FillDatasetFiles()
        {

            //WorkspaceModel workspaceModel = new WorkspaceModel();

            //List<FileWorkspace> files = workspaceModel.GetWorkspaceFiles(UserId);
            dgvFiles.DataSource = datasetModel.GetFiles(UserId,DatasetId);


            dgvFiles.Columns["DatasetId"].Visible = false;
            dgvFiles.Columns["SheetName"].Visible = false;
            dgvFiles.Columns["Id"].Visible = false;
            dgvFiles.Columns["UserId"].Visible = false;
            dgvFiles.Columns["StorageAccountName"].Visible = false;
            dgvFiles.Columns["Container"].Visible = false;
            dgvFiles.Columns["Path"].Visible = false;
            dgvFiles.Columns["CreateOn"].Visible = false;
            dgvFiles.Columns["IsDeleted"].Visible = false;

            dgvFiles.Columns["Name"].DisplayIndex = 0;
            dgvFiles.Columns["LastModifiedOn"].DisplayIndex = 1;
            dgvFiles.Columns["Size"].DisplayIndex =2;
            dgvFiles.Columns["Status"].DisplayIndex = 3;

            dgvFiles.Columns["Name"].Width = 380;
            dgvFiles.Columns["LastModifiedOn"].Width = 220;
            dgvFiles.Columns["Size"].Width = 200;
            dgvFiles.Columns["Status"].Width = 140;
            //dgvFiles.Columns[10].DisplayIndex = 3;
            //dgvFiles.Columns[10].DisplayIndex = 4;
            //dgvFiles.Columns[5].DisplayIndex = 4;
            //dgvFiles.Columns["Status"].DisplayIndex = 10;


            dgvMetadata.DataSource = datasetModel.GetDataset(UserId, DatasetId).columns;

            dgvMetadata.Columns["Id"].Visible = false;
            dgvMetadata.Columns["DatasetId"].Visible = false;
            dgvMetadata.Columns["CreateOn"].Visible = false;
            dgvMetadata.Columns["LastModifiedOn"].Visible = false;
            dgvMetadata.Columns["IsDeleted"].Visible = false;

            dgvMetadata.Columns["SourceColumn"].DisplayIndex = 0;
            dgvMetadata.Columns["ColumnName"].DisplayIndex = 2;
            dgvMetadata.Columns["ColumnDataType"].DisplayIndex = 3;
            dgvMetadata.Columns["ColumnModelType"].DisplayIndex = 4;
            dgvMetadata.Columns["MetricAggFunction"].DisplayIndex = 5;

            dgvMetadata.Columns["SourceColumn"].Width = 200;
            dgvMetadata.Columns["ColumnName"].Width = 200;
            dgvMetadata.Columns["ColumnDataType"].Width = 180;
            dgvMetadata.Columns["ColumnModelType"].Width = 180;
            dgvMetadata.Columns["MetricAggFunction"].Width = 180;

            //public string Id { get; set; }
            //public string DatasetId { get; set; }
            //public string SourceColumn { get; set; }
            //public string ColumnName { get; set; }
            //public string ColumnDataType { get; set; }
            //public string ColumnModelType { get; set; }
            //public string MetricAggFunction { get; set; }
            //public DateTime CreateOn { get; set; }
            //public DateTime LastModifiedOn 
            //public bool IsDeleted

        }

        private void txtSearchFiles_Enter(object sender, EventArgs e)
        {
            //if (txtSearchFiles.Text == "Search in Workspace")
            //{
            //    txtSearchFiles.Text = "";
            //    txtSearchFiles.ForeColor = Color.FromArgb(54,76,99);
            //}
        }

        private void txtSearchFiles_Leave(object sender, EventArgs e)
        {
            //if (txtSearchFiles.Text == "")
            //{
            //    txtSearchFiles.Text = "Search in Workspace";
            //    txtSearchFiles.ForeColor = System.Drawing.SystemColors.GrayText;
            //}
        }

        private void icbLoadData_Click(object sender, EventArgs e)
        {
            NewFile frm = new NewFile(DatasetId,UserId);
            frm.Show();
            FillDatasetFiles();
        }

        private void icbProcessDatasetFile_Click(object sender, EventArgs e)
        {
            //TODO
            if (dgvFiles.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvFiles.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvFiles.Rows[selectedrowindex];
                string datasetFileId = Convert.ToString(selectedRow.Cells["Id"].Value);
                datasetModel.ProcessDatasetFile(datasetFileId);
                FillDatasetFiles();
            }
          
        }

        private void lblDSGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibtConnect_Click(object sender, EventArgs e)
        {
          //TODO
        }
    }
}
