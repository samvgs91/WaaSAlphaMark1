using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WaaSDataAccess
{
    public class UserDao:DBConnector
    {
        public bool CreateUser(string UserName, string Email, string Password)
        {
            using ( var connection = GetConnection())
            {
                connection.Open();
                using ( var command = new SqlCommand() )
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[WaaS].[USP_WAAS_INS_USER]";

                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Password", Password);

                    var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    var result = returnParameter.Value;

                    if ((Int32)result == 1) return true;
                    else return false;
                }
            }

        }

        public bool Login(string UserNameOrEmail, string Password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[WaaS].[USP_WAAS_GET_LOGIN]";

                    command.Parameters.AddWithValue("@UserNameOrEmail", UserNameOrEmail);
                    command.Parameters.AddWithValue("@Password", Password);

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
