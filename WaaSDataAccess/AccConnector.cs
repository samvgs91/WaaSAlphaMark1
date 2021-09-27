using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using Azure.Storage.Files.DataLake;
using Azure.Storage;


namespace WaaSDataAccess
{
    public abstract class  AccConnector
    {
        private readonly string accountName;
        private readonly string accountKey;
        private readonly string dfsUri;
        private readonly string containerName;

        public AccConnector()
        {
            accountName = ConfigurationManager.AppSettings.Get("accountName");
            accountKey = ConfigurationManager.AppSettings.Get("accountKey");
            dfsUri = "https://" + accountName + ".dfs.core.windows.net";
            containerName = ConfigurationManager.AppSettings.Get("containerName");
        }

        protected string GetAccountName() { return accountName; }

        protected string GetContainerName() { return containerName; }


        protected DataLakeServiceClient GetConnection()
        {
            StorageSharedKeyCredential sharedKeyCredential = new StorageSharedKeyCredential(accountName, accountKey);

            return  new DataLakeServiceClient (new Uri(dfsUri), sharedKeyCredential);
        }

    }
}


