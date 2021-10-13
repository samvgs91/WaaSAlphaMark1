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
        public Dataset GetDataset(string FileId)
        {
            Dataset ds = new Dataset();
            return ds;
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
    }
}
