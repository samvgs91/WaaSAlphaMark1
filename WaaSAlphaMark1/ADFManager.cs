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



namespace WaaSAlphaMark1
{
    class ADFManager
    {
        static AuthenticationContext context;
        static ClientCredential cc;
        static ServiceClientCredentials cred;
        static AuthenticationResult result;
        static DataFactoryManagementClient adfClient;

        static string tenantID;
        static string applicationId;
        static string authenticationKey;
        static string resource;
        static string autority;
        static string dataFactoryName;
        static string subscriptionId;
        static string resourceGroup;
        

        static ADFManager()
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
            adfClient = new DataFactoryManagementClient(cred)
            {
                SubscriptionId = subscriptionId
            };
            

        }

        public static void LauchADFPipeline(Dictionary<string, object> parameters, String pipelineName)
        {
           
            CreateRunResponse runResponse = adfClient.Pipelines.CreateRunWithHttpMessagesAsync(
                       resourceGroup, dataFactoryName, pipelineName, parameters: parameters
                   ).Result.Body;
            Console.WriteLine("Pipeline run ID: " + runResponse.RunId);

            var runId = runResponse.RunId;

            Console.WriteLine("Checking pipeline run status...");

            PipelineRun pipelineRun;

            while (true)
            {
                pipelineRun = adfClient.PipelineRuns.Get(resourceGroup, dataFactoryName, runId);

                Console.WriteLine("Status: " + pipelineRun.Status);

                if (pipelineRun.Status == "InProgress" || pipelineRun.Status == "Queued")
                    System.Threading.Thread.Sleep(15000);
                else
                    break;
            }

        }
    }
}
