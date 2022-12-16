using IcloneExample;

Person p=new Person();
p.Name="Jhora";
p.Id=101;

Person p1= (Person)p.Clone();
Console.WriteLine(p1.Name);
Console.WriteLine(p1.Id);