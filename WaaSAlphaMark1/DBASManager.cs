using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AnalysisServices.AdomdClient;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace WaaSAlphaMark1
{
    class DBASManager
    {

         static AdomdConnection connection;
         static String connectionString;
         static String serverName;
         static String token;
        static DBASManager()
        {
            //await GetDataFromAzureAnalysisService();
            //   await ExecuteXMLAOnAzureAnalysisService() ;
            serverName = "asazure://aspaaseastus2.asazure.windows.net/aasasrvpocea201";

        }
        public static async Task ExecuteXMLAOnAzureAnalysisService(String xmlJson)
        {
            //Grab the token
            //Get servername from Azure Analysis Service (Overview) resource 
            //Format: asazure://<region>.asazure.windows.net/<servername>
            //var serverName = "asazure://aspaaseastus2.asazure.windows.net/aasasrvpocea201";
            var token = await GetAccessToken("https://westeurope.asazure.windows.net");
            var connectionString = $"Provider=MSOLAP;Data Source={serverName};Initial Catalog=WaaS Demo Database;User ID=;Password={token};Persist Security Info=True;Impersonation Level=Impersonate";

            try
            {
                //read data from AAS
                using (AdomdConnection connection = new AdomdConnection(connectionString))
                {
                    connection.Open();
                    AdomdCommand cmd = connection.CreateCommand();
                    cmd.CommandText = xmlJson;
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static async Task<string> GetAccessToken(string aasUrl)
        {
            //var tenantId = "aa0fda5b-fa1f-4585-a8e7-3b8dfc42312e";
            var appId = "72342ea8-14ff-40ca-86b8-e16cc62f00fb";
            var appSecret = "db__KZ~oBT5Go3kG4v4F5r6VOjC~xIFFco";
            string authorityUrl = $"https://login.microsoftonline.com/aa0fda5b-fa1f-4585-a8e7-3b8dfc42312e";

            var authContext = new AuthenticationContext(authorityUrl);

            // Config for OAuth client credentials 
            var clientCred = new ClientCredential(appId, appSecret);
            AuthenticationResult authenticationResult = await authContext.AcquireTokenAsync(aasUrl, clientCred);

            //get access token
            return authenticationResult.AccessToken;
        }

    }
}
