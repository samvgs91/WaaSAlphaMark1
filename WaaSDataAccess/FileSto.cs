using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Azure;
using Azure.Storage.Files.DataLake;
using Azure.Storage.Files.DataLake.Models;
using Azure.Storage;
using System.IO;
using ExcelDataReader;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace WaaSDataAccess
{
    public class FileSto:AccConnector
    { 

        public string GetAccount() { return GetAccountName(); }

        public string GetContainer() { return GetContainerName(); }
        public bool AddFile(string fileName,string destinyPath, string subDestinyPath, string sourcePath,string container)
        {

            DataLakeServiceClient connection = GetConnection();

            DataLakeFileSystemClient fileSystemClient =  connection.GetFileSystemClient (container);

            DataLakeDirectoryClient directoryClient = null;
                
            if(subDestinyPath != null)
            {
                DataLakeDirectoryClient parentDirectoryClient  = fileSystemClient.GetDirectoryClient(destinyPath);

                directoryClient = parentDirectoryClient.GetSubDirectoryClient(subDestinyPath);
            }
            else
            {
                directoryClient = fileSystemClient.GetDirectoryClient(destinyPath);
            }
                
                

            DataLakeFileClient fileClient = directoryClient.GetFileClient(fileName);
            

            FileStream fileStream = File.OpenRead(sourcePath);

            long fileSize = fileStream.Length;

            fileClient.Upload(fileStream,true);

            fileClient.Flush(position: fileSize);

            return true;
                
        }
        public bool DeleteFile(string fileName, string destinyPath, string subDestinyPath, string container)
        {

                DataLakeServiceClient connection = GetConnection();

                DataLakeFileSystemClient fileSystemClient = connection.GetFileSystemClient(container);

                DataLakeDirectoryClient directoryClient = null;

                if (subDestinyPath != null)
                {
                    DataLakeDirectoryClient parentDirectoryClient = fileSystemClient.GetDirectoryClient(destinyPath);

                    directoryClient = parentDirectoryClient.GetSubDirectoryClient(subDestinyPath);
                }
                else
                {
                    directoryClient = fileSystemClient.GetDirectoryClient(destinyPath);
                }

                directoryClient.DeleteFile(fileName);

                return true;
        }
        public bool CopyFile(string fileName, string sourcePath, string destinyPath, string subDestinyPath, string container)
        {

            DataLakeServiceClient connection = GetConnection();
            DataLakeFileSystemClient fileSystemClient = connection.GetFileSystemClient(container);
            DataLakeDirectoryClient sourceDirectoryClient = fileSystemClient.GetDirectoryClient(sourcePath);
            DataLakeDirectoryClient destinyDirectoryClient = fileSystemClient.GetDirectoryClient(destinyPath);
            DataLakeDirectoryClient destinySubDirectoryClient = destinyDirectoryClient.GetSubDirectoryClient(subDestinyPath);

            DataLakeFileClient sourcefileClient = sourceDirectoryClient.GetFileClient(fileName);

            DataLakeFileClient destinyFileClient = destinySubDirectoryClient.GetFileClient(fileName);

            using (var fileStream = sourcefileClient.OpenRead())
            {
                long fileSize = fileStream.Length;

                destinyFileClient.Upload(fileStream, true);

                destinyFileClient.Flush(position: fileSize);
            }

             return true;
        }
        public DataTable GetMetataFromExcelFile(string fileName, string destinyPath, string container)
        {
            DataLakeServiceClient connection = GetConnection();
            DataLakeFileSystemClient fileSystemClient = connection.GetFileSystemClient(container);
            DataLakeDirectoryClient DirectoryClient = fileSystemClient.GetDirectoryClient(destinyPath);
            DataLakeFileClient fileClient = DirectoryClient.GetFileClient(fileName);
            DataTable dt;
            DataTable metadata = new DataTable("Metadata");

            //DataTableCollection dataTableCollection;
            //DataTable dt;


            //using (var stream = fileClient.OpenRead())
            //{
            //    using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
            //    {
            //        DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
            //        {
            //            ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
            //        });
            //        dataTableCollection = result.Tables;
            //    }
            //}


            using (var stream = fileClient.OpenRead())
            {
                var excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                //ds = (DataSet)excelReader.Read();
                using (IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(stream))
                {
                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                    });

                    dt = result.Tables[0];

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


                }
            }


            //return dt;
            return metadata;

        }
        public DataTableCollection GetDataTablesFromExcelFile(string fileName, string destinyPath, string container)
        {
            DataLakeServiceClient connection = GetConnection();
            DataLakeFileSystemClient fileSystemClient = connection.GetFileSystemClient(container);
            DataLakeDirectoryClient DirectoryClient = fileSystemClient.GetDirectoryClient(destinyPath);
            DataLakeFileClient fileClient = DirectoryClient.GetFileClient(fileName);
            DataTableCollection sheets;


            using (var stream = fileClient.OpenRead())
            {
                var excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                //ds = (DataSet)excelReader.Read();
                using (IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(stream))
                {
                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                    });

                    sheets = result.Tables;

                }
            }
           
            return sheets;

        }
    }
}
