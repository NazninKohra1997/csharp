using ADONet_DataRead_Teacher_info;
using System.Data.SqlClient;

string connectionString = "Server=DESKTOP-GDUH6RD\\SQLEXPRESS;Database=3rd_database;Trusted_Connection=True;";



DataUtility utility =  new DataUtility(connectionString);



string command = "select * from Teacher_info";
List<Dictionary<string, object>> result=utility.ExecuteQuery(command);

foreach(var row in result)
{
    foreach(var col in row)
    {
        Console.Write($"{col.Key}:{col.Value}");
        Console.Write("\t");

    }
    Console.WriteLine();
}