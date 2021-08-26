using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaaSAlphaMark1
{
    class DBManager
    {

        public static SqlConnection sqlCon;
        static DBManager()
        {
            sqlCon = new SqlConnection("Data Source=dccsrveu2taller03.database.windows.net;Initial Catalog=dccadbeu2taller03;Persist Security Info=True;User ID=adminusr;Password=@psstaller01");
        }

        public String GetBlobId(String fileName, String userId)
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


        public String GetXMLJson(String TableId, String UserId)
        {
            DataTable dtBlogTable = new DataTable();

            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("[WaaS].[USP_WAAS_GET_MODEL_SCRIPT]", sqlCon);
            cmd.Parameters.AddWithValue("@TableId", TableId); // passing Datatable 
            cmd.Parameters.AddWithValue("@UserId", UserId); // passing Datatable 
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dtBlogTable);
            sqlCon.Close();
            String blobId = dtBlogTable.Rows[0].Field<Guid>("ModelCreationUptadeScript").ToString();

            return blobId;
        }

    }
}
