using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONet_Insert_for_table1
{
   public class DataUtility
    {
        private readonly string connectionString;

        public DataUtility(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void DataInsertion(string command, IList<SqlParameter> parameters)
        {
          
            GetCommand(command,parameters).ExecuteNonQuery();
        }

        private SqlCommand GetCommand(string command, IList<SqlParameter> parameters)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = command;

            cmd.Connection = connection;

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            cmd.Parameters.AddRange(parameters.ToArray());

            return cmd;
        }
    }
}
