using Microsoft.VisualBasic;

DateTime time = new DateTime();
Console.WriteLine(time);


DateTime time1 = new DateTime(2020,4,22,23,30,50);
Console.WriteLine(time1);
Console.WriteLine(time1.ToString("dd-MM-yy"));

DateTime time2 = time1.AddMonths(2);
Console.WriteLine(time2.ToString("dd-MM-yy"));

DateTime time3 = DateTime.Now;
Console.WriteLine(time3);

Console.WriteLine(time3.DayOfYear);