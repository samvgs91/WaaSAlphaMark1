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
using System.Data.OleDb;
using ExcelDataReader;

using WaaSDomain;



namespace WaaSAlphaMark1
{
    public partial class NewFile : Form
    {
        private string userId = string.Empty;
        private string datasetId = string.Empty;
        private string filePath = string.Empty;
        private string fileExt = string.Empty;
        private DataTable dtExcelData = new DataTable();
        private string SelectedSheet = string.Empty;
        private string fileName = string.Empty;
        private long fileSize;
        private DatasetModel datasetModel;

        public NewFile(string DatasetId,string UserId)
        {
            this.userId = UserId;
            this.datasetId = DatasetId;
            this.datasetModel = new DatasetModel();
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog file = new OpenFileDialog();//open dialog to choose file
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)//if there is a file choosen by the user
            {
                filePath = file.FileName;//get the path of the file
                fileName = file.SafeFileName;
                FileInfo fileInf = new FileInfo(filePath);
                fileSize = fileInf.Length;
                fileExt = Path.GetExtension(filePath);//get the file extension
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        txtFileName.Text = filePath;
                        cboSheet.Items.Clear();
                        cboSheet.Items.AddRange(GetSheetList(filePath).ToArray<String>());
                        cboSheet.SelectedIndex = cboSheet.Items.Count - 1;

                        SelectedSheet = cboSheet.Text;

                        dtExcelData = ReadExcelData(filePath, fileExt, SelectedSheet);

                        dgvData.DataSource = dtExcelData;
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

        private List<String> GetSheetList(string filePath)
        {
            DataTableCollection dataTableCollection;
            List<String> sheetNames = new List<string>();

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                {
                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                    });
                    dataTableCollection = result.Tables;

                    sheetNames = dataTableCollection.Cast<DataTable>().Select(t => t.TableName).ToList<string>();
                }
            }
            return sheetNames;
        }
        private DataTable ReadExcelData(string filePath, string fileExt, string sheetName)
        {
            DataTable dtExcelData = new DataTable();
            string conn = string.Empty;

            string oledbscript = "select TOP 100 * from [" + sheetName + "$]";

            if (fileExt.CompareTo(".xls") == 0)//compare the extension of the file
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';";//for below excel 2007
            else
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1';";//for above excel 2007
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {

                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter(oledbscript, con);//here we read data from sheet1
                    oleAdpt.Fill(dtExcelData);//fill excel data into dataTable

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

            return dtExcelData;

        }

        private void cboSheet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelectedSheet = cboSheet.Text;

            dtExcelData = ReadExcelData(filePath, fileExt, SelectedSheet);

            dgvData.DataSource = dtExcelData;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            //TODO
            datasetModel.AddNewFile(fileName, SelectedSheet, filePath, datasetId, userId, fileSize.ToString());
            this.Close();
        }
    }
}
