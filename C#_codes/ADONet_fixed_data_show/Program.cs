using ADONet_fixed_data_show;

string connectionString = @"Server = DESKTOP-GDUH6RD\SQLEXPRESS; Database = 3rd_database; Trusted_Connection = True;";

DataUtility dataUtility = new DataUtility(connectionString);

string command = "insert into Teacher_info(Name,Course,Room) values('Rabaa','English',508)";
//dataUtility.DataInsertion(command);

string query = "select * from Teacher_info";

dataUtility.Executequery(query);

