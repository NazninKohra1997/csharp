using ADONet;
using System.Data.SqlClient;

string connectionString = "Server=DESKTOP-GDUH6RD\\SQLEXPRESS;Database=3rd_database;Trusted_Connection=True;";
DataUtility dataUtility = new DataUtility(connectionString);

string Name = Console.ReadLine();
string Course = Console.ReadLine();
int Room = int.Parse(Console.ReadLine());

string command = "insert into Teacher_info(Name,Course,Room) values(@Name,@Course,@Room)";
List<SqlParameter> parameters = new List<SqlParameter>();

parameters.Add(new SqlParameter("Name",Name));
parameters.Add(new SqlParameter("Course", Course));
parameters.Add(new SqlParameter("Room", Room));


dataUtility.DataInsertion(command, parameters);