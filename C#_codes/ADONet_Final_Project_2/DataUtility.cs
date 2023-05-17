using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONet_Final_Project_2
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
           using SqlCommand cmd = connection.CreateCommand();
            cmd.Connection = connection;
           // cmd.CommandText = "delete from Teacher_info where Name='Ria'";
           cmd.CommandText= command;

            if(connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            cmd.ExecuteNonQuery();

           // connection.Close();
           // cmd.Dispose();
        }

        public void ExecuteQuery1(string query)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            using SqlCommand cmd = connection.CreateCommand();
            cmd.Connection = connection;
            // cmd.CommandText = "delete from Teacher_info where Name='Ria'";
            cmd.CommandText = query;

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

           SqlDataReader reader = cmd.ExecuteReader();

           while(reader.Read())
            {
                Console.WriteLine($"Id:{reader["ID"]}, Name:{reader["Name"]}, Course:{reader["Course"]}");
            }

        }

        public List<Dictionary<string, object>> ExecuteQuery(string query)
        {   
            List<Dictionary<string,object>> result = new List<Dictionary<string,object>>();
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

                for(int i=0;i<reader.FieldCount;i++)
                {
                    dict.Add(reader.GetName(i), reader.GetValue(i));
                }
                result.Add(dict);
            }
            return result;
        }
    }
}
