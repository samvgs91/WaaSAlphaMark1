using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaaSDomain;
using WaaSEntities;

namespace WaaSAlphaMark1
{
    public partial class DatasetDataTest : Form
    {
        private string DatasetId;
        private string UserId;

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

            dataGridView1.DataSource = datasetModel.GetDataSetData(UserId,DatasetId);
        }
    }
}
