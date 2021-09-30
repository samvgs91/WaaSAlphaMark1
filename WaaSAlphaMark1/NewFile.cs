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



namespace WaaSAlphaMark1
{
    public partial class NewFile : Form
    {
        public NewFile()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            string fileExt = string.Empty;

            OpenFileDialog file = new OpenFileDialog();//open dialog to choose file
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)//if there is a file choosen by the user
            {
                string filePath = file.FileName;//get the path of the file
                string fileName = file.SafeFileName;
                FileInfo fileInf = new FileInfo(filePath);
                long fileSize = fileInf.Length;
                fileExt = Path.GetExtension(filePath);//get the file extension
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        WorkspaceModel workspaceModel = new WorkspaceModel();
                        //workspaceModel.AddFile(fileName, "abcId","TableDemoDW", filePath, fileSize.ToString());
                        txtFileName.Text = filePath;

                        ////Upload the file and insert the record in the database
                        //UploadFileByName(filePath, fileName);
                        //DatasetBlobInsert(userId, tableName, storageName, containerName, fileName);
                        //FillDataFromTable(tableName);
                        ////LaunchADFProcess();
                        //txtFileName.Enabled = false;

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
