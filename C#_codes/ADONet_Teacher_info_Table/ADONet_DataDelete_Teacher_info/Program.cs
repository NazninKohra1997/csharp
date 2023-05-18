using ADONet_DataDelete_Teacher_info;
using System.Data.SqlClient;

string connectionString = @"Server = DESKTOP-GDUH6RD\SQLEXPRESS; Database = 3rd_database; Trusted_Connection = True;";
DataUtility dataUtility = new DataUtility(connectionString);

List<SqlParameter> parameters = new List<SqlParameter>();

Console.WriteLine("Enter the name which data you want to remove");
string name = Console.ReadLine();

parameters.Add(new SqlParameter("name", name));

string command = $"delete from Teacher_info where Name= @name";



dataUtility.DataDeletion(command, parameters);

