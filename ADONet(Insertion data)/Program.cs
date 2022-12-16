using AdoNetExample;
using System.Data.SqlClient;


string connectionString = @"Server = DESKTOP-6CHMV3E\SQLEXPRESS; Database = CSharpB12; Trusted_Connection = True;";
DataUtility dataUtility = new DataUtility(connectionString);

int Id = int.Parse(Console.ReadLine());
string Title = Console.ReadLine();
int Fees = int.Parse(Console.ReadLine());

string commandText = $"insert into My_1st_sql (Id, Title, Fees,CourseCode) values(@Id, @Title, @Fees, '{Guid.NewGuid()}')";

List<SqlParameter> parameters = new List<SqlParameter>();
parameters.Add(new SqlParameter("Id", Id));
parameters.Add(new SqlParameter("Fees", Fees));
parameters.Add(new SqlParameter("Title", Title));

string query="select * from My_1st_sql";
dataUtility.ExecuteCommand(commandText, parameters);

