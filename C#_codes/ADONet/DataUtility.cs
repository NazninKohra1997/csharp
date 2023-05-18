using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ADONet
{
    public class DataUtility
    {
        private readonly string connectionString;

        public DataUtility(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void DataInsertion(string command,IList<SqlParameter> parameters)
        {
          GetCommand(command, parameters).ExecuteNonQuery();
            
        }

        private SqlCommand GetCommand(string Command, IList<SqlParameter> parameters)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = connection.CreateCommand();
            cmd.Connection = connection;
            cmd.CommandText = Command;
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            cmd.Parameters.AddRange(parameters.ToArray());

            return cmd;
        }
    }
}
