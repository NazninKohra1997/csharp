using ADONet_Data_insertion;


string ConnectionString = "Server=DESKTOP-GDUH6RD\\SQLEXPRESS ; Database=1st_database; Trusted_Connection=True";
string command = "insert into Course(Title,IsOpen,Time,CourseId) values('CSS',1,'5/04/24','BF39A470-DA09-486C-9D41-FBCFAADF0257')";

DataUtility utility = new DataUtility(ConnectionString);

utility.DataInsertion(command);

