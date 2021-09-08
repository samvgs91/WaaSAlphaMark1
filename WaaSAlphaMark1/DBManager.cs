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
