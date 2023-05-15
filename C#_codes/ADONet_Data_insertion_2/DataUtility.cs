﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ADONet_Data_insertion_2
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
            
            //string connectionString = "Server=DESKTOP-GDUH6RD\\SQLEXPRESS;Database=2nd_database;Trusted_Connection=True;";
            using SqlConnection connection = new SqlConnection(connectionString);
            using SqlCommand cmd = connection.CreateCommand();
            cmd.Connection = connection;
            //cmd.CommandText = "insert into Student_info(Name,Roll,Course,Marks) values('Jhora',37,'EEE',89)";
            cmd.CommandText = command;

            if(connection.State!= System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            cmd.ExecuteNonQuery();
        }
    }
}
