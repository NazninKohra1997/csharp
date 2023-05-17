using ADONet_Final_Code_2;

string connectionString = "Server=DESKTOP-GDUH6RD\\SQLEXPRESS;Database=3rd_database;Trusted_Connection=True;";
Data data = new Data(connectionString);

string query = "select * from Teacher_info";

List<Dictionary<string, object>> result = data.ExecuteQuery(query);

foreach (var row in result)
{
    foreach (var col in row)
    {
        Console.Write($"{col.Key}:{col.Value}");
        Console.Write("\t");
    }
    Console.WriteLine();
}