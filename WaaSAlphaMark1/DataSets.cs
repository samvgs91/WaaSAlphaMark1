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
        private int currentMouseOverRow;

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
            dgvDatasets.Columns[2].Width = 220;
            dgvDatasets.Columns[3].Width = 200;
            dgvDatasets.Columns[4].Width = 200;
            dgvDatasets.Columns[5].Visible = false;
            dgvDatasets.Columns[6].Width = 150;
            dgvDatasets.Columns[7].Width = 130;
            dgvDatasets.Columns[8].Width = 130;
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

        private void DisplayFileOptions(object sender, MouseEventArgs e)
        {
            //TODO
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Delete", DeleteFileOnClick));
                m.MenuItems.Add(new MenuItem("Create Model", CreateModel));
                m.MenuItems.Add(new MenuItem("Download", MenuOnClick));

                currentMouseOverRow = dgvDatasets.HitTest(e.X, e.Y).RowIndex;

                //if (currentMouseOverRow >= 0)
                //{
                //    m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                //}

                m.Show(dgvDatasets, new Point(e.X, e.Y));

            }
        }

        private void DeleteFileOnClick(object sender, EventArgs args)
        {
            //TODO
        }
        private void CreateModel(object sender, EventArgs args)
        {
            //TODO
        }
        private void MenuOnClick(object sender, EventArgs args)
        {
            //TODO
        }
    }
}
