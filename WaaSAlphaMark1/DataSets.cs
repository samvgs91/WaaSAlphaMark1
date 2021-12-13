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
    public partial class DataSets : Form
    {

        private string UserId;

        public DataSets(string userId)
        {
            this.UserId = userId;
            InitializeComponent();
            LoadConfiguration();
        }

        private void ibtNewFile_Click(object sender, EventArgs e)
        {

            //TODO

        }

        private void LoadConfiguration()
        {

            DatasetModel datasetModel = new DatasetModel();

            //List<FileWorkspace> files = workspaceModel.GetWorkspaceFiles(UserId);
            dgvDatasets.DataSource = datasetModel.GetDatasets(UserId);


            dgvDatasets.Columns[0].Visible = false;
            dgvDatasets.Columns[1].Visible = false;
            dgvDatasets.Columns[2].Width = 450;
            dgvDatasets.Columns[3].Width = 250;
            dgvDatasets.Columns[4].Width = 250;
            dgvDatasets.Columns[5].Visible = false;
            //dgvDatasets.Columns[6].Visible = false;
            //dgvDatasets.Columns[4].Visible = false;
            //dgvDatasets.Columns[5].Visible = false;
            //dgvDatasets.Columns[6].Visible = false;
            //dgvDatasets.Columns[7].Visible = false;
            //dgvDatasets.Columns[8].Width = 350;
            //dgvDatasets.Columns[9].Visible = false;

            //dgvDatasets.Columns[3].DisplayIndex = 8;
            //dgvDatasets.Columns[8].DisplayIndex = 3;


        }

        private void txtSearchFiles_Enter(object sender, EventArgs e)
        {
            if (txtSearchFiles.Text == "Search in Workspace")
            {
                txtSearchFiles.Text = "";
                txtSearchFiles.ForeColor = Color.FromArgb(54,76,99);
            }
        }

        private void txtSearchFiles_Leave(object sender, EventArgs e)
        {
            if (txtSearchFiles.Text == "")
            {
                txtSearchFiles.Text = "Search in Workspace";
                txtSearchFiles.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }
    }
}
