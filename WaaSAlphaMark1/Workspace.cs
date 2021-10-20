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
    public partial class Workspace : Form
    {

        private string UserId;
        private int currentMouseOverRow;
        private string SelectedFileId;
        public event EventHandler Selected;

        public Workspace(string userId)
        {
            this.UserId = userId;
            this.currentMouseOverRow = -1;
            InitializeComponent();
            FillWorkspaceFiles();

        }

        private void ibtNewFile_Click(object sender, EventArgs e)
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
                        WorkspaceModel workspaceModel = new WorkspaceModel();

                        workspaceModel.AddFile(fileName, UserId, filePath, fileSize.ToString());

                        FillWorkspaceFiles();
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
            if(e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Delete",DeleteFileOnClick));
                m.MenuItems.Add(new MenuItem("Create Dataset", CreateDataSet));
                m.MenuItems.Add(new MenuItem("Download", MenuOnClick));

                currentMouseOverRow = dgvWorkspace.HitTest(e.X, e.Y).RowIndex;

                //if (currentMouseOverRow >= 0)
                //{
                //    m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                //}

                m.Show(dgvWorkspace, new Point(e.X, e.Y));
               
            }
        }

        private void dgvWorkspace_MouseClick(object sender, MouseEventArgs e)
        {
            DisplayFileOptions(sender, e);
        }

        private void DeleteFileOnClick(object sender, EventArgs args)
        {
            if (currentMouseOverRow > -1)
            {
                string fileId = dgvWorkspace.Rows[currentMouseOverRow].Cells[0].Value.ToString();
                WorkspaceModel workspaceModel = new WorkspaceModel();
                workspaceModel.DeleteFile(fileId);
                FillWorkspaceFiles();
            }
        }

        private void MenuOnClick(object sender, EventArgs args)
        {
            //TODO
            MenuItem mi = (MenuItem)sender;
            //MessageBox.Show(mi.Text);

            if(currentMouseOverRow>0)
            {
                string fileId = dgvWorkspace.Rows[currentMouseOverRow].Cells[0].Value.ToString();
                MessageBox.Show(fileId);
            }
        }

        private void CreateDataSet(object sender, EventArgs args)
        {
            SelectedFileId = dgvWorkspace.Rows[currentMouseOverRow].Cells[0].Value.ToString();
            //MessageBox.Show(SelectedFileId);
            this.Close();
            SelectFile(null);
        }
        protected virtual void SelectFile(EventArgs e)
        {
            EventHandler eh = Selected;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        public string GetSelectedFile()
        {
            return SelectedFileId;
        }
    }
}
