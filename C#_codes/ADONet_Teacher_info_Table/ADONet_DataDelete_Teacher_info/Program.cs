using ADONet_DataDelete_Teacher_info;
using System.Data.SqlClient;

string connectionString = @"Server = DESKTOP-GDUH6RD\SQLEXPRESS; Database = 3rd_database; Trusted_Connection = True;";
DataUtility dataUtility = new DataUtility(connectionString);




string command = "delete from Teacher_info where Name= 'Raisa'";

dataUtility.DataDeletion(command);

