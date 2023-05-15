using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONetExample_2
{
   public class DataUtility_2
    {
        public void InsertData_2()
        {
            string connectionString = @"Server=DESKTOP-GDUH6RD\SQLEXPRESS;Database=2nd_database;Trusted_Connection=True";
            SqlConnection connection = new SqlConnection(connectionString);
            
            SqlCommand cmd = connection.CreateCommand();
            cmd.Connection = connection;

            cmd.CommandText = "insert into Student_info(Name,Roll,Course,Marks) values ('Musaib',20,'html',95)";

            if(connection.State!= System.Data.ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            cmd.ExecuteNonQuery();

            connection.Close();
            cmd.Dispose();

        }
    }
}
