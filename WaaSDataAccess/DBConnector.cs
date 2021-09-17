using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace WaaSDataAccess
{
    public abstract class DBConnector
    {
        private readonly string connectionString;

        public DBConnector()
        {
            connectionString = ConfigurationManager.AppSettings.Get("sqlStrCon");
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
