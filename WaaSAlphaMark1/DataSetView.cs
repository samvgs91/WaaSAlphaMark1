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
                this.lblDatasetName.Text = "Dataset > " + ds.Name;
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


            dgvFiles.Columns[0].Visible = false;
            //dgvFiles.Columns[1].Width = 350; //Status
            dgvFiles.Columns[2].Visible = false;
            dgvFiles.Columns[3].Visible = false;
            //dgvFiles.Columns[4].Width = 150; // Name
            //dgvFiles.Columns[5].Width = 150; // Size
            dgvFiles.Columns[6].Visible = false;
            dgvFiles.Columns[7].Visible = false;
            dgvFiles.Columns[8].Visible = false;
            dgvFiles.Columns[9].Visible = false;
            //dgvFiles.Columns[10].Width = 250; //Date Mod
            dgvFiles.Columns[11].Visible = false;

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
            OpenFileDialog file = new OpenFileDialog();//open dialog to choose file
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)//if there is a file choosen by the user
            {
                string filePath = file.FileName;//get the path of the file
                string fileName = file.SafeFileName;
                string fileExt = Path.GetExtension(filePath);//get the file extension
                FileInfo fileInf = new FileInfo(filePath);
                long fileSize = fileInf.Length;
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        datasetModel.AddNewFile(fileName, filePath, DatasetId, UserId, fileSize.ToString());
                        FillDatasetFiles();
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
    }
}
