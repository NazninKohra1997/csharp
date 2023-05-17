using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONet_Fixed_data_show_2
{
    public class DataUtility
    {
        private readonly string connectionString;

        public DataUtility(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void DataDeletion(string command)
        {
           // string connectionString = "Server=DESKTOP-GDUH6RD\\SQLEXPRESS;Database=3rd_database;Trusted_Connection=True;";
            using SqlConnection connection = new SqlConnection(connectionString);

           using SqlCommand cmd = connection.CreateCommand();
            cmd.Connection = connection;

            //cmd.CommandText = "delete from Teacher_info where Name='Raisa'";

            cmd.CommandText = command;

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            cmd.ExecuteNonQuery();

           // connection.Close();
            //cmd.Dispose();
        }

        public void ExecuteQuery(string query)
        {
            using SqlConnection connection = new SqlConnection(connectionString);

            using SqlCommand cmd = connection.CreateCommand();
            cmd.Connection = connection;

            //cmd.CommandText = "delete from Teacher_info where Name='Raisa'";

            cmd.CommandText = query;

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Id:{reader["Id"]},Name:{reader["Name"]}, Course:{reader["Course"]}, Room:{reader["Room"]}");
            }


        }
    }
}
