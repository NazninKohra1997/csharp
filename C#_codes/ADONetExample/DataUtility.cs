using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONetExample
{
    public class DataUtility
    {
        public void InsertData()
        {
            string ConnectionString = @"Server =DESKTOP-GDUH6RD\SQLEXPRESS; Database = 3rd_database; Trusted_Connection = True";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = connection.CreateCommand();
            cmd.Connection = connection;
            cmd.CommandText = "Insert into Teacher_info(Name,Course,Room) values('Rita','Bangla',506)";

            if(connection.State!= System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            cmd.ExecuteNonQuery();
            

        }
    }
}
