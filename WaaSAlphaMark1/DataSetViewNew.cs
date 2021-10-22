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
    public partial class DatasetViewNew : Form
    {

        private string UserId;
        private string StartedFileId;

        public DatasetViewNew(string userId,string fileId)
        {
            this.UserId = userId;
            this.StartedFileId = fileId;
            InitializeComponent();
            FillWorkspaceFiles();

        }

        private void ibtNewFile_Click(object sender, EventArgs e)
        {

        }

        private void FillWorkspaceFiles()
        {

            WorkspaceModel workspaceModel = new WorkspaceModel();

            //List<FileWorkspace> files = workspaceModel.GetWorkspaceFiles(UserId);
            dgvMetadata.DataSource = workspaceModel.GetMetadataFromFile(StartedFileId);


            dgvMetadata.Columns["SourceColumn"].Width = 180;
            dgvMetadata.Columns["SourceColumn"].ReadOnly = true;
            dgvMetadata.Columns["ColumnName"].Width = 180;
            dgvMetadata.Columns["ColumnName"].ReadOnly = true;
            dgvMetadata.Columns["ColumnDataType"].Width = 180;
            dgvMetadata.Columns["ColumnDataType"].ReadOnly = true;
            dgvMetadata.Columns["ColumnModelType"].Width = 200;
            dgvMetadata.Columns["ColumnModelType"].ReadOnly = true;
            dgvMetadata.Columns["ColumnMetricType"].Width = 210;
            dgvMetadata.Columns["ColumnMetricType"].ReadOnly = true;

        }

        private void dgvMetadata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1)
            {

                DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();

                //int selectedrowindex = dgvFiles.SelectedCells[e.].RowIndex;
                //DataGridViewRow selectedRow = dgvFiles.Rows[selectedrowindex];
                //string colTypeName = Convert.ToString(selectedRow.Cells["ColumnModelType"].Value);
                string colTypeName = "";
                //var cell = dgvMetadata.Rows[e.RowIndex].Cells[4];

                if (e.ColumnIndex > 0)
                {
                    colTypeName = dgvMetadata.Rows[e.RowIndex].Cells[3].Value.ToString();
                }

                if (dgvMetadata.Columns[e.ColumnIndex].Name.Contains("ColumnModelType"))
                {
                    dgvMetadata.Columns["ColumnModelType"].ReadOnly = false;
                    dgvMetadata[e.ColumnIndex, e.RowIndex] = comboBoxCell;
                    comboBoxCell.DataSource = GetListComboxModelColumnType();
                    comboBoxCell.ValueMember = "ModelColumnType";
                    comboBoxCell.DisplayMember = "ModelColumnType";

                    if (dgvMetadata.Rows[e.RowIndex].Cells[3].Value.ToString() == "Attribute")
                    {
                        dgvMetadata.Rows[e.RowIndex].Cells[4].Value = "";
                    }

                }
                else
                if (dgvMetadata.Columns[e.ColumnIndex].Name.Contains("ColumnMetricType") && colTypeName == "Metric")
                {
                    dgvMetadata.Columns["ColumnMetricType"].ReadOnly = false;
                    dgvMetadata[e.ColumnIndex, e.RowIndex] = comboBoxCell;
                    comboBoxCell.DataSource = GetListComboxModelAggFunc();
                    comboBoxCell.ValueMember = "ColMetricFuncType";
                    comboBoxCell.DisplayMember = "ColMetricFuncType";
                }


            }
        }

        private DataTable GetListComboxModelAggFunc()
        {
            DataTable dtModelMetricFuncType = new DataTable();
            dtModelMetricFuncType.Columns.Add("ColMetricFuncType", typeof(string));

            dtModelMetricFuncType.Rows.Add("");
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
