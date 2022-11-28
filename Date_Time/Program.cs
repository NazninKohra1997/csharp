DateTime date= new DateTime();
//Console.WriteLine(date);

DateTime date1=new DateTime(2022,11,12,10,31,25);
Console.WriteLine(date1.ToString("dd/MM/yy"));
Console.WriteLine(date1.ToString("hh:mm:ss tt"));

Console.WriteLine();

DateTime date2= DateTime.Now;
Console.WriteLine(date2);

Console.WriteLine();

DateTime date3= DateTime.UtcNow;
Console.WriteLine(date3);

Console.WriteLine();


date3=date3.AddMonths(2);
Console.WriteLine(date3);

//Console.WriteLine(date3.DayofYear);

Console.WriteLine(date3.Subtract(date1));
