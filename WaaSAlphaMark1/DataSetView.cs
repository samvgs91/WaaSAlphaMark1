﻿using System;
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
        private string StartedFileId;

        public DatasetView(string userId,string fileId)
        {
            this.UserId = userId;
            this.StartedFileId = fileId;
            InitializeComponent();
            //FillWorkspaceFiles();

            if(StartedFileId != null)
            {
                this.lblDatasetName.Text = "Dataset > Demo >" + StartedFileId;
            }
        }

        private void ibtNewFile_Click(object sender, EventArgs e)
        {

        }

        private void FillWorkspaceFiles()
        {

            WorkspaceModel workspaceModel = new WorkspaceModel();

            //List<FileWorkspace> files = workspaceModel.GetWorkspaceFiles(UserId);
            dgvWorkspace.DataSource = workspaceModel.GetWorkspaceFiles(UserId);


            dgvWorkspace.Columns[0].Visible = false;
            dgvWorkspace.Columns[1].Visible = false;
            dgvWorkspace.Columns[2].Width = 450;
            dgvWorkspace.Columns[3].Width = 250;
            dgvWorkspace.Columns[4].Visible = false;
            dgvWorkspace.Columns[5].Visible = false;
            dgvWorkspace.Columns[6].Visible = false;
            dgvWorkspace.Columns[7].Visible = false;
            dgvWorkspace.Columns[8].Width = 350;
            dgvWorkspace.Columns[9].Visible = false;

            dgvWorkspace.Columns[3].DisplayIndex = 8;
            dgvWorkspace.Columns[8].DisplayIndex = 3;


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
    }
}
