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
    public class DatasetDao : DBConnector
    {
        public bool CreateDataSet(string UserId,string Name)
        {

            ///DataTable dt
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[WaaS].[USP_WAAS_INS_DATASET]";

                    command.Parameters.AddWithValue("@UserId", UserId);
                    command.Parameters.AddWithValue("@Name", Name);

                    var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    var result = returnParameter.Value;

                    if ((Int32)result == 1) return true;
                    else return false;
                }
            }
        }
        public bool DeleteDataset(string DatasetId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[WaaS].[USP_WAAS_DEL_DATASET]";

                    command.Parameters.AddWithValue("@DatasetId", DatasetId);


                    var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    var result = returnParameter.Value;

                    if ((Int32)result == 1) return true;
                    else return false;
                }
            }
        }
        public Dataset GetDataset(string DatasetId)
        {
            Dataset ds = new Dataset();
            return ds;
        }
        public string GetDatesetId(string UserId, string DatasetName)
        {
            string datasetId = String.Empty;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[WaaS].[USP_WAAS_GET_DATASET_ID_BY_NAME]";

                    command.Parameters.AddWithValue("@userId", UserId);
                    command.Parameters.AddWithValue("@datasetName", DatasetName);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            datasetId = reader.GetString(0);
                        }

                        return datasetId;
                    }

                }
            }
        }
        public List<Dataset> GetDatasets(string UserId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "[WaaS].[USP_WAAS_GET_DATASETS]";
                    command.Parameters.AddWithValue("@userId", UserId);
                    command.CommandType = CommandType.StoredProcedure;

                    List<Dataset> files = new List<Dataset>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dataset file = new Dataset();

                            file.Id = reader.GetString(0);
                            file.UserId = reader.GetString(1);
                            file.Name = reader.GetString(2);
                            file.CreateOn = reader.GetDateTime(3);
                            file.LastModifiedOn = reader.GetDateTime(4);
                            file.IsDeleted = Convert.ToBoolean(reader.GetInt16(5));

                            files.Add(file);
                        }

                        return files;
                    }

                }
            }
        }
        public bool InsertDataSetMetadata(DataTable metadata,string datasetId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[WaaS].[USP_WAAS_INS_DATASET_METADATA]";

                    command.Parameters.AddWithValue("@metadata", metadata);
                    command.Parameters.AddWithValue("@datasetId", datasetId);

                    var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    var result = returnParameter.Value;

                    if ((Int32)result == 1) return true;
                    else return false;
                }
            }
        }
        public void GenerateDatasetConfiguration(string datasetId,string sheetName)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[WaaS].[USP_WAAS_INS_DATASET_CONFIGURATION]";

                    command.Parameters.AddWithValue("@DatasetId", datasetId);
                    command.Parameters.AddWithValue("@SheetName", sheetName);
                    command.ExecuteNonQuery();
                }
            }
        }
        public bool InsertDatasetFile(string UserId, string DatasetId, string FileName, string StorageAccount, string Container, string Path, string Size)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[WaaS].[USP_WAAS_INS_DATASET_FILE]";

                    command.Parameters.AddWithValue("@UserId", UserId);
                    command.Parameters.AddWithValue("@DataSetId", DatasetId);
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
        public bool DeleteDatasetFile(string FileId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[WaaS].[USP_WAAS_DEL_DATASET_FILE]";

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
        public FileDataset GetDatasetFileByName(string DatasetId, string FileName) 
        {
            FileDataset file = new FileDataset();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[WaaS].[USP_WAAS_GET_DATASET_FILE_BY_NAME]";

                    command.Parameters.AddWithValue("@DatasetId", DatasetId);
                    command.Parameters.AddWithValue("@FileName", FileName);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            file.Id = reader.GetString(0);
                            file.UserId = reader.GetString(1);
                            file.DatasetId = reader.GetString(2);
                            file.Name = reader.GetString(3);
                            file.Size = reader.GetInt32(4);
                            file.StorageAccountName = reader.GetString(5);
                            file.Container = reader.GetString(6);
                            file.Path = reader.GetString(7);
                            file.CreateOn = reader.GetDateTime(8);
                            file.LastModifiedOn = reader.GetDateTime(9);
                            file.Status = reader.GetString(10);
                            file.IsDeleted = Convert.ToBoolean(reader.GetInt16(11));
                        }

                        return file;
                    }

                }
            }
        }
        public FileDataset GetDatasetFileById(string FileId)
        {
            FileDataset file = new FileDataset();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[WaaS].[USP_WAAS_GET_DATASET_FILE_BY_ID]";

                    command.Parameters.AddWithValue("@FileId", FileId);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            file.Id = reader.GetString(0);
                            file.UserId = reader.GetString(1);
                            file.DatasetId = reader.GetString(2);
                            file.Name = reader.GetString(3);
                            file.Size = reader.GetInt32(4);
                            file.StorageAccountName = reader.GetString(5);
                            file.Container = reader.GetString(6);
                            file.Path = reader.GetString(7);
                            file.CreateOn = reader.GetDateTime(8);
                            file.LastModifiedOn = reader.GetDateTime(9);
                            file.Status = reader.GetString(10);
                            file.IsDeleted = Convert.ToBoolean(reader.GetInt16(11));
                        }

                        return file;
                    }

                }
            }
        }
        public List<FileDataset> GetDatasetFiles(string DatasetId, string UserId)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "[WaaS].[USP_WAAS_GET_DATASET_FILES]";
                    command.Parameters.AddWithValue("@userId", UserId);
                    command.Parameters.AddWithValue("@datasetId", DatasetId);
                    command.CommandType = CommandType.StoredProcedure;

                    List<FileDataset> files = new List<FileDataset>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FileDataset file = new FileDataset();

                            file.Id = reader.GetString(0);
                            file.UserId = reader.GetString(1);
                            file.DatasetId = reader.GetString(2);
                            file.Name = reader.GetString(3);
                            file.Size = reader.GetInt32(4);
                            file.StorageAccountName = reader.GetString(5);
                            file.Container = reader.GetString(6);
                            file.Path = reader.GetString(7);
                            file.CreateOn = reader.GetDateTime(8);
                            file.LastModifiedOn = reader.GetDateTime(9);
                            file.Status = reader.GetString(10);
                            file.IsDeleted = Convert.ToBoolean(reader.GetInt16(11));

                            files.Add(file);
                        }

                        return files;
                    }

                }
            }
        }
        public bool DeployDataset(string DatasetId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[WaaS].[USP_WAAS_DEPLOY_DATASET]";

                    command.Parameters.AddWithValue("@DatasetId", DatasetId);

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
