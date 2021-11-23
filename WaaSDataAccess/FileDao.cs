using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using WaaSEntities;


namespace WaaSDataAccess
{
    public class FileDao:DBConnector
    {
        public bool InsertWorkspaceFile(string UserId, string FileName,string StorageAccount,string Container,string Path,string Size)
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
        public bool DeleteWorkspaceFile(string FileId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[WaaS].[USP_WAAS_DEL_FILE]";

                    command.Parameters.AddWithValue("@FileId", FileId);
  

                    var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    var result = returnParameter.Value;

                    if ((Int32)result == 1) return true;
                    else return false;
                }
            }
        }
        public FileWorkspace GetWorkspaceFile(string FileId)
        {
            FileWorkspace file = new FileWorkspace();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[WaaS].[USP_WAAS_GET_FILE_BY_ID]";

                    command.Parameters.AddWithValue("@FileId", FileId);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        { 
                            file.Id = reader.GetString(0);
                            file.UserId = reader.GetString(1);
                            file.Name = reader.GetString(2);
                            file.Size = reader.GetInt32(3);
                            file.StorageAccountName = reader.GetString(4);
                            file.Container = reader.GetString(5);
                            file.Path = reader.GetString(6);
                            file.CreateOn = reader.GetDateTime(7);
                            file.LastModifiedOn = reader.GetDateTime(8);
                            file.IsDeleted = Convert.ToBoolean(reader.GetInt16(9));
                        }

                        return file;
                    }

                }
            }

        }
        public List<FileWorkspace> GetWorkspaceFiles(string UserId)
        {         
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "[WaaS].[USP_WAAS_GET_FILES]";
                    command.Parameters.AddWithValue("@userId", UserId);
                    command.CommandType = CommandType.StoredProcedure;

                    List<FileWorkspace> files = new List<FileWorkspace>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FileWorkspace file = new FileWorkspace();

                            file.Id = reader.GetString(0);
                            file.Name = reader.GetString(1);
                            file.Size = reader.GetInt32(2);
                            file.StorageAccountName = reader.GetString(3);
                            file.Container = reader.GetString(4);
                            file.Path = reader.GetString(5);
                            file.CreateOn = reader.GetDateTime(6);
                            file.LastModifiedOn = reader.GetDateTime(7);
                            file.IsDeleted = Convert.ToBoolean(reader.GetInt16(8));

                            files.Add(file);
                        }

                        return files;
                    }

                }
            }
        }


    }
}
