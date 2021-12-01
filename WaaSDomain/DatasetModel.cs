using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WaaSDataAccess;
using WaaSEntities;

namespace WaaSDomain
{
    public class DatasetModel
    {
        private DatasetDao datasetDao = new DatasetDao();
        private ADFProcessManager adfProcessManager = new ADFProcessManager();
        private FileSto fileSto = new FileSto();
        private string filePipelineProcessor = "WaaSDataLoader";

        public bool CreateDataset(string UserId, string Name, DataTable metadata,string sheetName)
        {
            bool datasetDaoBool = datasetDao.CreateDataSet(UserId, Name);
            if (datasetDaoBool)
            {   string datasetId = datasetDao.GetDatesetId(UserId, Name);
                bool metadataDaoBool = datasetDao.InsertDataSetMetadata(metadata, datasetId);
                if (metadataDaoBool)
                {
                    datasetDao.GenerateDatasetConfiguration(datasetId, sheetName);
                    return true;
                }
                else
                {
                    DeleteDataset(datasetId);
                    return false;
                }
               
            }
            else
            {  return false; }
            
        }

        public bool DeleteDataset(string DatasetId)
        {
            //We need to add methods to delete others files
            return datasetDao.DeleteDataset(DatasetId);
        }

        public List<Dataset> GetDatasets(string UserId)
        {
            return datasetDao.GetDatasets(UserId);
        }

        public void ProcessDatasetFile(string BlobId, string UserId)
        { 
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "blobId", BlobId},
                { "userId", UserId}
            };

            adfProcessManager.LauchADFPipeline(parameters, filePipelineProcessor);
        }

        public string GetDatasetId(string UserId, string DatasetName)
        {
            return datasetDao.GetDatesetId(UserId, DatasetName);
        }

        public bool AddFileFromWorkspace(string UserId, string DatasetId, FileWorkspace sourceFile)
        {
            string fileSize = sourceFile.Size.ToString();
            string dsFilePath = sourceFile.Path + "/" + DatasetId;
            

            bool dsFilebool = datasetDao.InsertDatasetFile(UserId, DatasetId, sourceFile.Name, sourceFile.StorageAccountName , sourceFile.Container, dsFilePath, fileSize);
            bool fsFilebool = fileSto.CopyFile(sourceFile.Name, sourceFile.Path, sourceFile.Path, DatasetId, sourceFile.Container);

            return true;
        }

        public bool AddNewFile()
        {
            return true;
        }

    }
}
