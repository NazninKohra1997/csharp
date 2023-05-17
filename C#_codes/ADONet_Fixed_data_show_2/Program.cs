using ADONet_Fixed_data_show_2;

string connectionString = "Server=DESKTOP-GDUH6RD\\SQLEXPRESS;Database=3rd_database;Trusted_Connection=True;";

DataUtility dataUtility = new DataUtility(connectionString);

string command = "delete from Teacher_info where Name='Rabaa'";

dataUtility.DataDeletion(command);

string query = "select * from Teacher_info";

dataUtility.ExecuteQuery(query);