using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excel = Microsoft.Office.Interop.Excel;

using System.Windows.Forms;
using WaaSDomain;
using WaaSEntities;

namespace WaaSAlphaMark1
{
    public partial class DatasetDataTest : Form
    {
        private string DatasetId;
        private string UserId;
        private DataTable dt;

        public DatasetDataTest(string UserId,string DatasetId)
        {
            this.DatasetId = DatasetId;
            this.UserId = UserId;
            InitializeComponent();
            FillDatasetFiles();
        }

        private void FillDatasetFiles()
        {
            DatasetModel datasetModel = new DatasetModel();
            dt = datasetModel.GetDataSetData(UserId, DatasetId);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string excelFilePath = "C:\\Users\\user\\Downloads\\demo.xlsx";
            var excelApp = new Excel.Application();

            excelApp.Workbooks.Add();

            // single worksheet
            Excel._Worksheet workSheet = excelApp.ActiveSheet;

            // column headings
            for (var i = 0; i < dt.Columns.Count; i++)
            {
                workSheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
            }

            // rows
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                // to do: format datetime values before printing
                for (var j = 0; j < dt.Columns.Count; j++)
                {
                    workSheet.Cells[i + 2, j + 1] = dt.Rows[i][j];
                }
            }


            if (!string.IsNullOrEmpty(excelFilePath))
            {
                try
                {
                    workSheet.SaveAs(excelFilePath);
                    excelApp.Quit();
                    MessageBox.Show("Excel file saved!");
                }
                catch (Exception ex)
                {
                    throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                                        + ex.Message);
                }
            }
            else
            { // no file path is given
                excelApp.Visible = true;
            }
        }
    }
}
