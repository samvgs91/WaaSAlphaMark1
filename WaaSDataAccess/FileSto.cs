using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Azure;
using Azure.Storage.Files.DataLake;
using Azure.Storage.Files.DataLake.Models;
using Azure.Storage;
using System.IO;

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
    }
}
