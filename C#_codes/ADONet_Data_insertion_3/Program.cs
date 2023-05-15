using ADONet_Data_insertion_3;
string connectionString = "Server=DESKTOP-GDUH6RD\\SQLEXPRESS;Database=3rd_database;Trusted_Connection=True;";

DataUtility utility = new DataUtility(connectionString);

string command = "insert into Teacher_info(Name,Course,Room) values('Jalil','Science',612)";

utility.DataInsertion(command);