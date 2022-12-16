using AdoNetExample;
using System.Data.SqlClient;


string connectionString = @"Server = DESKTOP-6CHMV3E\SQLEXPRESS; Database = CSharpB12; Trusted_Connection = True;";
DataUtility dataUtility = new DataUtility(connectionString);

string commandText = $"insert into My_1st_sql (Id, Title, Fees,CourseCode) values(@Id, @Title, @Fees, '{Guid.NewGuid()}')";

List<SqlParameter> parameters = new List<SqlParameter>();

string query="select * from My_1st_sql";
string deleteCommand = "delete from My_1st_sql where Id = 101";
dataUtility.ExecuteCommand(deleteCommand,parameters);





