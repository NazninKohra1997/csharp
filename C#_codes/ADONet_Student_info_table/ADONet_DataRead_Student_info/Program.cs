using ADONet_DataRead_Student_info;

string connectionString = "Server=DESKTOP-GDUH6RD\\SQLEXPRESS;Database=2nd_database;Trusted_Connection=True;";

DataUtility utility = new DataUtility(connectionString);
string command = "select * from Student_info";

List<Dictionary<string,object>> list = utility.DataRead(command);

foreach(var row in list)
{
    foreach(var col in row)
    {
        Console.Write($"{col.Key}:{ col.Value}");
        Console.Write("\t");
    }
    Console.WriteLine();
}