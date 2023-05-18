using ADONet_DataInsert_Student_info;
using System.Data.SqlClient;

string connectionString = "Server=DESKTOP-GDUH6RD\\SQLEXPRESS;Database=2nd_database;Trusted_Connection=True;";

DataUtility utility = new DataUtility(connectionString);

List<SqlParameter> parameters = new List<SqlParameter>();
Console.WriteLine("Enter the data");
Console.WriteLine("Name");
string Name = Console.ReadLine();
Console.WriteLine("Roll");
int Roll = int.Parse(Console.ReadLine());
Console.WriteLine("Course");
string Course= Console.ReadLine();
Console.WriteLine("Marks");
int Marks= int.Parse(Console.ReadLine());

string command = "insert into Student_info(Name,Roll,Course,Marks) values(@Name,@Roll,@Course,@Marks)";
string query = "delete from Student_info where Name='Musaib'";

parameters.Add(new SqlParameter("Name", Name));
parameters.Add(new SqlParameter("Roll", Roll));
parameters.Add(new SqlParameter("Course", Course));
parameters.Add(new SqlParameter("Marks", Marks));

utility.InsertData(command, parameters);

//utility.InsertData(query, parameters); These two can't be called at a time.


