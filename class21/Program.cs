DateTime date1= new DateTime(2022,11,26);
//Console.WriteLine(date1.ToString("d"));

//Console.WriteLine(date1.ToString("dd-MM-yyyy"));

//Console.WriteLine(date1.ToString("MM/dd/yy"));

//Console.WriteLine(date1.ToString("dddd/MMMM/yyyy"));

DateTime date2=new DateTime(2022,11,26,2,15,45);
//Console.WriteLine(date2.ToString("dddd/MMMM/yyyy"));
//Console.WriteLine(date2.ToString("hh:mm:ss tt"));


//Console.WriteLine(date2.Subtract(date1));

DateTime date3=DateTime.Now;
//Console.WriteLine(date3);

DateTime date4=DateTime.UtcNow;
//Console.WriteLine(date4);

date2=date2.AddMonths(2);
Console.WriteLine(date2);

