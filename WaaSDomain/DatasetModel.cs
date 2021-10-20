using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaaSDataAccess;

namespace WaaSDomain
{
    public class DatasetModel
    {
        DatasetDao datasetDao = new DatasetDao();

        public bool CreateDataset(string UserId, string Name)
        {
            return datasetDao.CreateDataSet(UserId, Name);
        }

        public bool DeleteDataset(string DatasetId)
        {
            //We need to add methods to delete others files
            return datasetDao.DeleteDataset(DatasetId);
        }
    }
}
