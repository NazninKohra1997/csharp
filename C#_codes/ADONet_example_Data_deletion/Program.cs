using ADONet_example_Data_deletion;

string connectionString = "Server=DESKTOP-GDUH6RD\\SQLEXPRESS;Database=3rd_database;Trusted_Connection=True;";

DataUtility utility = new DataUtility(connectionString);

string command = "delete from Teacher_info where id=7";
utility.DataDeletion(command);