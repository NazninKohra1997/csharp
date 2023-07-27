using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class DataUtility
    {
        private readonly string ConnectionString;

        public DataUtility(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        public void DataInsertion(string commandText)
        {
            //string ConnectionString = "Server=DESKTOP-GDUH6RD\\SQLEXPRESS ; Database=1st_database; Trusted_Connection=True";

            
            using SqlConnection connection = new SqlConnection(ConnectionString);
            using SqlCommand cmd = connection.CreateCommand();
            cmd.Connection = connection;
            //cmd.CommandText = "insert into Course(Title,IsOpen,Time,CourseId) values('php',0,'1/04/24','BF39A470-DA09-486C-9D41-FBCFAADF0257')";
            try
            {
                cmd.CommandText = commandText;

                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

                cmd.ExecuteNonQuery();
            }

            catch(SqlException ex)
            {
                throw;
            }

            finally
            {

            }
        }
    }
}