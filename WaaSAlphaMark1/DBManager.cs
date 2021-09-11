using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;

namespace WaaSAlphaMark1
{
    class DBManager
    {

        static SqlConnection sqlCon;
        static String StrCon;

        static DBManager()
        {
            StrCon = ConfigurationManager.AppSettings.Get("sqlStrCon");
            sqlCon = new SqlConnection(StrCon);
        }

        public static String GetBlobId(String fileName, String userId)
        {
            DataTable dtBlogTable = new DataTable();

            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("[WaaS].[USP_WAAS_GET_BLOBID_BY_FILENAME]", sqlCon);
            cmd.Parameters.AddWithValue("@fileName", fileName); // passing Datatable 
            cmd.Parameters.AddWithValue("@userId", userId); // passing Datatable 
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dtBlogTable);
            sqlCon.Close();
            String blobId = dtBlogTable.Rows[0].Field<Guid>("BlobPathId").ToString();

            return blobId;
        }

        public static int InsertBlobRecord(String userId, String tableName, String storageName, String containerName, String fileName)
        {

            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("[WaaS].[USP_WAAS_BLOBPATH_INSERT]", sqlCon);
            cmd.Parameters.AddWithValue("@UserId", userId); // passing UserIde 
            cmd.Parameters.AddWithValue("@UserTableName", tableName); // passing UserTableName 
            cmd.Parameters.AddWithValue("@StorageAccount", storageName); // passing StorageAccountName 
            cmd.Parameters.AddWithValue("@Path", containerName); // passing Path
            cmd.Parameters.AddWithValue("@FileName", fileName); // passing fileName
            cmd.CommandType = CommandType.StoredProcedure;
            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            var result = returnParameter.Value;
            sqlCon.Close();
            return (int)result;
        }

        public static String GetXMLJson(String TableId, String UserId, String Type)
        {
            DataTable dtBlogTable = new DataTable();
            var XMLJson = String.Empty;

            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("[WaaS].[USP_WAAS_GET_MODEL_SCRIPT]", sqlCon);
            cmd.Parameters.AddWithValue("@TableId", TableId); // passing Datatable 
            cmd.Parameters.AddWithValue("@UserId", UserId); // passing Datatable 
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dtBlogTable);
            sqlCon.Close();
            
            switch(Type)
            {
                case "Create":
                    XMLJson = dtBlogTable.Rows[0].Field<String>("ModelCreationUptadeScript").ToString();
                    break;
                case "Process":
                    XMLJson = dtBlogTable.Rows[0].Field<String>("ModelProcessScript").ToString();
                    break;
                case "Drop":
                    XMLJson = dtBlogTable.Rows[0].Field<String>("ModelDropScript").ToString();
                    break;
            }
           

            return XMLJson;
        }

    }
}
