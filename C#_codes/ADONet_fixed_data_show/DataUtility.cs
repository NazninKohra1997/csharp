using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONet_fixed_data_show
{
   public class DataUtility
    {
        public readonly string connectionString;

        public DataUtility(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void DataInsertion(string command)
        {
            //string connectionString = @"Server = DESKTOP-GDUH6RD\SQLEXPRESS; Database = 3rd_database; Trusted_Connection = True;";
            using SqlConnection connection = new SqlConnection(connectionString);
           using  SqlCommand cmd = connection.CreateCommand();
            cmd.Connection = connection;
            //cmd.CommandText = "insert into Teacher_info(Name,Course,Room) values('Ria','English',508)";
            cmd.CommandText = command;

            if(connection.State!= System.Data.ConnectionState.Open)
            {
                connection.Open();  
            }

            cmd.ExecuteNonQuery();

            //connection.Close();
            //cmd.Dispose();
        }

        public void Executequery(string query)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            using SqlCommand cmd = connection.CreateCommand();
            cmd.Connection = connection;
            //cmd.CommandText = "insert into Teacher_info(Name,Course,Room) values('Ria','English',508)";
            cmd.CommandText = query;

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            //cmd.ExecuteNonQuery();

            SqlDataReader reader = cmd.ExecuteReader();
           
            while (reader.Read())
            {
                Console.WriteLine($"Name: {reader["Name"]},Course: {reader["Course"]},Room: {reader["Room"]}");
                
            }

        }
    }
}
