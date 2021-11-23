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
    public class WorkspaceModel
    {
        FileSto fileSto = new FileSto();
        FileDao fileDao = new FileDao();

        public bool AddFile(string fileName, string destinyPath, string sourcePath,string size)
        {
            string accountName = fileSto.GetAccount();
            string containerName = fileSto.GetContainer();
            string userId = destinyPath;
            string path = containerName + "/" + userId;


            //   workspaceModel.AddFile(fileName, "abcId","TableDemoDW", filePath, "waas-data");
            bool fileDaoBool = fileDao.InsertWorkspaceFile(userId, fileName, accountName, containerName, path, size);
            bool fileStoBool = fileSto.AddFile(fileName, destinyPath, null, sourcePath, containerName);

            if (fileDaoBool && fileStoBool)
                return true;
            else
                return false;
        }
        public bool DeleteFile(string fileId)
        {
            string containerName = fileSto.GetContainer();

            FileWorkspace file = fileDao.GetWorkspaceFile(fileId);

            bool fileStoBool = fileSto.DeleteFile(file.Name, file.UserId, null, containerName);
            bool fileDaoBool = fileDao.DeleteWorkspaceFile(fileId);

            if (fileDaoBool && fileStoBool)
                return true;
            else
                return false;
        }
        public DataTable GetMetadataFromFile(string fileId,string sheetName)
        {
            DataTable metadata = new DataTable("Metadata"); ;
            DataTable dt;
            FileWorkspace file = fileDao.GetWorkspaceFile(fileId);
            string containerName = fileSto.GetContainer();

            DataTableCollection sheetsDataTablesCollection = fileSto.GetDataTablesFromExcelFile(file.Name, file.UserId, containerName);
            dt = sheetsDataTablesCollection.Cast<DataTable>().Where(t => t.TableName == sheetName).FirstOrDefault();

            metadata.Columns.Add("SourceColumn", typeof(string));
            metadata.Columns.Add("ColumnName", typeof(string));
            metadata.Columns.Add("ColumnDataType", typeof(string));
            metadata.Columns.Add("ColumnModelType", typeof(string));
            metadata.Columns.Add("ColumnMetricType", typeof(string));

            int contador = 1;
            foreach (DataColumn column in dt.Columns)
            {
                metadata.Rows.Add(contador, column.ColumnName.ToString(), column.DataType.ToString().Replace("System.", ""), "Attribute", "");
                contador += 1;
            }

            //metadata = 

            return metadata;
        }
        public List<String> GetSheetList(string fileId)
        {
            string containerName = fileSto.GetContainer();
            FileWorkspace file = fileDao.GetWorkspaceFile(fileId);
            DataTableCollection sheetsDataTables = fileSto.GetDataTablesFromExcelFile(file.Name, file.UserId, containerName);

            List<String> sheetNames = sheetsDataTables.Cast<DataTable>().Select(t => t.TableName).ToList<string>();
            return sheetNames;
        }
       public FileWorkspace GetWorkspaceFile(string FileId)
        {
            return fileDao.GetWorkspaceFile(FileId);
        }
        //public DataTable GetWorkspaceFiles(string userId)
        //{
        //    DataTable dt = new DataTable();

        //    dt.TableName = "WorkspaceFiles";
        //    dt.Columns.Add("Id", typeof(string));
        //    dt.Columns.Add("Name", typeof(string));
        //    dt.Columns.Add("Size", typeof(string));
        //    dt.Columns.Add("StorageAccountName", typeof(string));
        //    dt.Columns.Add("Container", typeof(string));
        //    dt.Columns.Add("Path", typeof(string));
        //    dt.Columns.Add("CreateOn", typeof(DateTime));
        //    dt.Columns.Add("LastModifiedOn", typeof(DateTime));

        //    FileDao fileDao = new FileDao();

        //    List<FileWorkspace> files = fileDao.GetFiles(userId);


        //    foreach(FileWorkspace f in files)
        //    {
        //        dt.Rows.Add(f.Id, f.Name, f.Size, f.StorageAccountName, f.Container, f.Path, f.CreateOn, f.LastModifiedOn);
        //    }

        //    return dt;
        //}


        public List<FileWorkspace> GetWorkspaceFiles(string userId)
        {
            return fileDao.GetWorkspaceFiles(userId);
        }

    }
}
