using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONetExample3
{
   public class DataUtility3
    {
        public void InsertData3()
        {

            string connectionString = "Server=DESKTOP-GDUH6RD\\SQLEXPRESS;Database=1st_database;Trusted_Connection=True";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = connection.CreateCommand();
            cmd.Connection = connection;

            cmd.CommandText = "insert into Course(Title,IsOpen,CourseId,Time) values('html',1,'CE31123D-1E0D-400F-BDA8-9A1E0D93FB36','10/5/2022')";

            if(connection.State!=System.Data.ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            cmd.ExecuteNonQuery();
             
        }
    }
}
