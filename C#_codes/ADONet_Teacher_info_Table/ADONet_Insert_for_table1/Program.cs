using ADONet_Insert_for_table1;
using System.Data.SqlClient;

string connectionString = "Server=DESKTOP-GDUH6RD\\SQLEXPRESS;Database=3rd_database;Trusted_Connection=True;";
DataUtility dataUtility = new DataUtility(connectionString);

Console.WriteLine("Enter Name");
string Name = Console.ReadLine();

Console.WriteLine("Enter Course");
string Course = Console.ReadLine();

Console.WriteLine("Enter room");
int Room = int.Parse(Console.ReadLine());

List<SqlParameter> parameters = new List<SqlParameter>();
parameters.Add(new SqlParameter("Name", Name));
parameters.Add(new SqlParameter("Course", Course));
parameters.Add(new SqlParameter("Room", Room));

string command = "insert into Teacher_info(Name,Course,Room) values(@Name,@Course,@Room)";

dataUtility.DataInsertion(command, parameters);