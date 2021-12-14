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
            dgvFiles.Columns[1].Visible = false;
            dgvFiles.Columns[2].Visible = false;
            dgvFiles.Columns[3].Width = 250;
            dgvFiles.Columns[4].Width = 250;
            dgvFiles.Columns[5].Visible = false;
            dgvFiles.Columns[6].Visible = false;
            dgvFiles.Columns[7].Visible = false;
            dgvFiles.Columns[8].Visible = false;
            dgvFiles.Columns[9].Width = 250;
            dgvFiles.Columns[10].Width = 250;
            dgvFiles.Columns[11].Visible = false;

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
