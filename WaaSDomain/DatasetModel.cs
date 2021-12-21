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


        public bool CreateDataset(string UserId, string Name, DataTable metadata,string sheetName,FileWorkspace sourceFile)
        {
            bool datasetDaoBool = datasetDao.CreateDataSet(UserId, Name);
            if (datasetDaoBool)
            {   string datasetId = datasetDao.GetDatasetId(UserId, Name);
                bool metadataDaoBool = datasetDao.InsertDataSetMetadata(metadata, datasetId);
                if (metadataDaoBool)
                {
                    datasetDao.GenerateDatasetConfiguration(datasetId, sheetName);
                    datasetDao.DeployDataset(datasetId);

                    string fileSize = sourceFile.Size.ToString();
                    string dsFilePath = sourceFile.Path + "/" + datasetId;

                    bool dsFilebool = datasetDao.InsertDatasetFile(UserId, datasetId, sourceFile.Name, sheetName, sourceFile.StorageAccountName, sourceFile.Container, dsFilePath, fileSize);
                    bool fsFilebool = fileSto.CopyFile(sourceFile.Name, sourceFile.Path, sourceFile.Path, datasetId, sourceFile.Container);

                    FileDataset fileDataset = datasetDao.GetDatasetFileByName(datasetId, sourceFile.Name);

                    //datasetDao.GetDatasetFileByName(datasetId,)
                    //string newDatasetId = datasetModel.GetDatasetId(UserId, txtDatasetName.Text);
                    //FileWorkspace wsFile = workspace.GetWorkspaceFile(StartedFileId);

                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { "DatasetFileId", fileDataset.Id}
                    };

                    adfProcessManager.LauchADFPipeline(parameters, filePipelineProcessor);

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

        public Dataset GetDataset(string userId, string datasetId)
        {
            return datasetDao.GetDataset(userId, datasetId);
        }
        public List<FileDataset> GetFiles(string UserId, string DatasetId)
        {
            return datasetDao.GetDatasetFiles(DatasetId, UserId);
        }

        public void ProcessDatasetFile(string DatasetFileId)
        { 
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "DatasetFileId", DatasetFileId}
            };

            adfProcessManager.LauchADFPipeline(parameters, filePipelineProcessor);
            datasetDao.UpdateDatasetFile(DatasetFileId);
        }

        public string GetDatasetId(string UserId, string DatasetName)
        {
            return datasetDao.GetDatasetId(UserId, DatasetName);
        }

        public FileDataset GetDatasetFileByName(string DatasetId, string FileName)
        {
            return datasetDao.GetDatasetFileByName(DatasetId,FileName);
        }

        private bool AddFileFromWorkspace(string UserId, string DatasetId, FileWorkspace sourceFile)
        {
            string fileSize = sourceFile.Size.ToString();
            string dsFilePath = sourceFile.Path + "/" + DatasetId;
            

            bool dsFilebool = datasetDao.InsertDatasetFile(UserId, DatasetId, sourceFile.Name, sourceFile.StorageAccountName , sourceFile.Container, dsFilePath, fileSize);
            bool fsFilebool = fileSto.CopyFile(sourceFile.Name, sourceFile.Path, sourceFile.Path, DatasetId, sourceFile.Container);

            return true;
        }

        public bool AddNewFile(string fileName, string sourcePath, string datasetId, string userId, string size)
        {
            string accountName = fileSto.GetAccount();
            string containerName = fileSto.GetContainer();
            //string userId = destinyPath;
            string path = containerName + "/" + userId + "/"+ datasetId;
            bool dsFileBool = datasetDao.InsertDatasetFile(userId, datasetId, fileName, accountName, containerName, path,size);
            bool fsFileBool = fileSto.AddFile(fileName, userId, datasetId, sourcePath, containerName);

            if(dsFileBool && fsFileBool)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
