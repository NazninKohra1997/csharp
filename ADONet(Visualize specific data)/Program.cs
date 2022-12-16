using AdoNetExample;
using System.Data.SqlClient;

string connectionString = @"Server = DESKTOP-6CHMV3E\SQLEXPRESS; Database = CSharpB12; Trusted_Connection = True;";
DataUtility dataUtility = new DataUtility(connectionString);

int Fees=int.Parse(Console.ReadLine());
string query = "select * from My_1st_sql where Fees = @Fees";

List<SqlParameter> parameters = new List<SqlParameter>();
parameters.Add(new SqlParameter("Fees", Fees));

List<Dictionary<string, object>> result = dataUtility.ExecuteQuery(query, parameters);

foreach (var row in result)
{
    foreach (var col in row)
    {
        Console.Write($"{col.Key}:{col.Value}");
        Console.Write(" ");
    }
    Console.WriteLine();
}