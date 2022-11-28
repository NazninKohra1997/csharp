using EnumExample;

Student st=new Student("Rahim",10,101);
Console.WriteLine(st.Name);
Console.WriteLine(st.Id);
Console.WriteLine(st.Roll);
Console.WriteLine();

Console.WriteLine((int)UserStatus.Active);
Console.WriteLine((int)UserStatus.Lock);
Console.WriteLine((int)UserStatus.Pending);
Console.WriteLine((int)UserStatus.Off);
Console.WriteLine((int)UserStatus.On);
