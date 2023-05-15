using ADONet_Data_insertion_2;

string connectionString = "Server=DESKTOP-GDUH6RD\\SQLEXPRESS;Database=2nd_database;Trusted_Connection=True;";

string command = "insert into Student_info(Name,Roll,Course,Marks) values('Jhora',37,'EEE',89)";



DataUtility utility = new DataUtility(connectionString);
utility.DataInsertion(command);