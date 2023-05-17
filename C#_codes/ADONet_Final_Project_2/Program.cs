using ADONet_Final_Project_2;

string connectionString = "Server=DESKTOP-GDUH6RD\\SQLEXPRESS;Database=3rd_database;Trusted_Connection=True;";
DataUtility utility = new DataUtility(connectionString);

string command = "delete from Teacher_info where Name='Raka'";
utility.DataInsertion(command);

string query = "select * from Teacher_info";

//utility.ExecuteQuery(query);

List<Dictionary<string,object>> result = utility.ExecuteQuery(query);

foreach(var row in result)
{
    foreach(var col in row)
    {
        Console.Write($"{col.Key}:{col.Value}");
        Console.Write("\t");
    }
    Console.WriteLine();
}