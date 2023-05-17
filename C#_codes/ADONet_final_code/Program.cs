using ADONet_final_code;

string connectionString = "Server=DESKTOP-GDUH6RD\\SQLEXPRESS;Database=3rd_database;Trusted_Connection=True;";

DataUtility dataUtility = new DataUtility(connectionString);

//string command = "insert into Teacher_info (Name,Course,Room) values('Reba','Bangla',511)";
string command = "delete  from Teacher_info where (Name='Reba')";

dataUtility.DataInsertion(command);

string query = "select * from Teacher_info";

//dataUtility.ExecuteQuery(query);

List<Dictionary<string,object>> result = dataUtility.ExecuteQuery(query);

foreach(var row in result)
{
    foreach(var col in row)
    {
        Console.Write($"{col.Key}:{col.Value}");
        Console.Write("\t");

    }
    Console.WriteLine();
    
}