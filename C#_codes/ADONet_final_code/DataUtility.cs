using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ADONet_final_code
{
   public class DataUtility
    {
        private readonly string connectionString;

        public DataUtility(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void DataInsertion(string command)
        {
           // string connectionString = "Server=DESKTOP-GDUH6RD\\SQLEXPRESS;Database=3rd_database;Trusted_Connection=True;";
            using SqlConnection connection = new SqlConnection(connectionString);
           using  SqlCommand cmd = connection.CreateCommand();
            cmd.Connection = connection;
           // cmd.CommandText = "insert into Teacher_info (Name,Course,Room) values('Raisa','Bangla',511)";
           cmd.CommandText = command;

            if(connection.State!=ConnectionState.Open)
            {
                connection.Open();
            }

            cmd.ExecuteNonQuery();
            //connection.Close();
            //cmd.Dispose();
        }

        public List<Dictionary<string,object>> ExecuteQuery(string query)
        {
            List<Dictionary<string,object>> result = new List<Dictionary<string,object>>();
            using SqlConnection connection = new SqlConnection(connectionString);
            using SqlCommand cmd = connection.CreateCommand();
            cmd.Connection = connection;
            // cmd.CommandText = "insert into Teacher_info (Name,Course,Room) values('Raisa','Bangla',511)";
            cmd.CommandText = query;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                Dictionary<string, object> dict = new Dictionary<string, object>();

                // Console.WriteLine($"Id:{reader["Id"]}, Name:{reader["Name"]}, Course:{reader["Course"]}, Room:{reader["Room"]}");
                for (var i=0; i<reader.FieldCount; i++)
                {

                    dict.Add(reader.GetName(i), reader.GetValue(i));

                }

                result.Add(dict);
            }
            return result;

        }
        
    }
}
