using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ADONet_Data_insertion_3
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
           // cmd.CommandText = "insert into Teacher_info(Name,Course,Room) values('karim','Data Science',612)";

            cmd.CommandText = command;

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            cmd.ExecuteNonQuery();
           // connection.Close();
            //cmd.Dispose();
        }
    }
}
