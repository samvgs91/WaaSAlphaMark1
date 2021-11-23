using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using Microsoft.Rest;
using Microsoft.Azure.Management.DataFactory;
using Microsoft.Azure.Management.DataFactory.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace WaaSDataAccess
{
    public abstract class ADFConnector
    {
        private readonly string accountName;
        private readonly string accountKey;
        private readonly string dfsUri;
        private readonly string containerName;


        private readonly AuthenticationContext context;
        private readonly ClientCredential cc;
        private readonly ServiceClientCredentials cred;
        private readonly AuthenticationResult result;
        private readonly DataFactoryManagementClient adfClient;


        private readonly string tenantID;
        private readonly string applicationId;
        private readonly string authenticationKey;
        private readonly string resource;
        private readonly string autority;
        private readonly string dataFactoryName;
        private readonly string subscriptionId;
        private readonly string resourceGroup;

        public ADFConnector()
        {
            tenantID = ConfigurationManager.AppSettings.Get("tenantID");
            applicationId = ConfigurationManager.AppSettings.Get("applicationId");
            authenticationKey = ConfigurationManager.AppSettings.Get("authenticationKey");
            resource = ConfigurationManager.AppSettings.Get("resource");
            autority = ConfigurationManager.AppSettings.Get("autority") + tenantID;
            dataFactoryName = ConfigurationManager.AppSettings.Get("dataFactoryName");
            subscriptionId = ConfigurationManager.AppSettings.Get("subscriptionId");
            resourceGroup = ConfigurationManager.AppSettings.Get("resourceGroup");

            context = new AuthenticationContext(autority);
            cc = new ClientCredential(applicationId, authenticationKey);
            result = context.AcquireTokenAsync(resource, cc).Result;
            cred = new TokenCredentials(result.AccessToken);
            adfClient = new DataFactoryManagementClient(cred);

        }

        public DataFactoryManagementClient GetADFClient()
        {
            return adfClient;
        }

       public string GetResourceGroup()
        {
            return resourceGroup;
        }

        public string GetDataFactoryName()
        {
            return dataFactoryName;
        }
 
    }
    
}
