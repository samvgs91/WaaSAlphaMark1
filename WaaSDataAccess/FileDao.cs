using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WaaSDataAccess
{
    public class FileDao:DBConnector
    {
        public bool InsertFile(string UserId, string FileName,string StorageAccount,string Container,string Path,string Size)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[WaaS].[USP_WAAS_INS_FILE]";

                    command.Parameters.AddWithValue("@UserId", UserId);
                    command.Parameters.AddWithValue("@FileName", FileName);
                    command.Parameters.AddWithValue("@StorageAccount", StorageAccount);
                    command.Parameters.AddWithValue("@Container", Container);
                    command.Parameters.AddWithValue("@Path", Path);
                    command.Parameters.AddWithValue("@Size", Size);

                    var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    var result = returnParameter.Value;

                    if ((Int32)result == 1) return true;
                    else return false;
                }
            }
        }

    }
}
