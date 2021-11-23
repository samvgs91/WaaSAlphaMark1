using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Rest;
using Microsoft.Azure.Management.DataFactory;
using Microsoft.Azure.Management.DataFactory.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace WaaSDataAccess
{
    public class ADFProcessManager : ADFConnector
    {

        public void LauchADFPipeline(Dictionary<string, object> parameters, string pipelineName)
        {

            DataFactoryManagementClient client =  GetADFClient();
            string resourceGroup = GetResourceGroup();
            string dataFactoryName = GetDataFactoryName();

            CreateRunResponse runResponse = client.Pipelines.CreateRunWithHttpMessagesAsync(
            resourceGroup, dataFactoryName, pipelineName, parameters: parameters).Result.Body;
            

            var runId = runResponse.RunId;

            PipelineRun pipelineRun;

            while (true)
            {
                pipelineRun = client.PipelineRuns.Get(resourceGroup, dataFactoryName, runId);

                if (pipelineRun.Status == "InProgress" || pipelineRun.Status == "Queued")
                    System.Threading.Thread.Sleep(15000);
                else
                    break;
            }
        }
    }
}
