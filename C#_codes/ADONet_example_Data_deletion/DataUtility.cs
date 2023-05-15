using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONet_example_Data_deletion
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
           // cmd.CommandText = "delete from Teacher_info where id=6";
           cmd.CommandText = command;

            if(connection.State!= System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            cmd.ExecuteNonQuery();
            //connection.Close();
            //cmd.Dispose();

        }
    }
}
