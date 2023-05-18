using ADONet_specific_dataSearch;
using System.Data.SqlClient;

string connectionString = "Server=DESKTOP-GDUH6RD\\SQLEXPRESS;Database=2nd_database;Trusted_Connection=True;";


DataUtility dataUtility = new DataUtility(connectionString);

List<SqlParameter> parameters = new List<SqlParameter>();

Console.WriteLine("Enter the data you want to see:");
Console.WriteLine("Enter Name");

string name = Console.ReadLine();

parameters.Add(new SqlParameter("Name", name));

string command = $"select * from Student_info where Name=@name";

List<Dictionary<string,object>> result = dataUtility.DataRead(command, parameters);

foreach(var row in result)
{
    foreach(var col in row)
    {
        Console.Write($"{col.Key}:{col.Value}");
        Console.Write("\t");
    }
    Console.WriteLine();
}
