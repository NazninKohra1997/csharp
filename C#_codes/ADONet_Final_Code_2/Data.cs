using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADONet_Final_Code_2
{
    public class Data
    {
        private readonly string connectionString;
        public Data(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<Dictionary<string, object>> ExecuteQuery(string query)
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            using SqlConnection connection = new SqlConnection(connectionString);
            using SqlCommand cmd = connection.CreateCommand();
            cmd.Connection = connection;
            cmd.CommandText = query;

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Dictionary<string, object> dict = new Dictionary<string, object>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dict.Add(reader.GetName(i), reader.GetValue(i));
                }
                result.Add(dict);
            }
            return result;
        }

    }
}
