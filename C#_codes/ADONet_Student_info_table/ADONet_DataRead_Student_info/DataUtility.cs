using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONet_DataRead_Student_info
{
    public class DataUtility
    {
        private readonly string connectionString;

        public DataUtility(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Dictionary<string,object>> DataRead(string query)
        {
            List<Dictionary<string,object>> result = new List<Dictionary<string,object>>();
            
           SqlDataReader reader = GetCommand(query).ExecuteReader();

            while (reader.Read()){
                Dictionary<string, object> dict = new Dictionary<string, object>();
               for(int i=0; i < reader.FieldCount; i++)
                {
                    dict.Add(reader.GetName(i),reader.GetValue(i));

                }
               result.Add(dict);
            }
            return result;

        }

        private SqlCommand GetCommand(string command)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = command;
            cmd.Connection = connection;
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            return cmd;
        }
    }
}
