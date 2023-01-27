using generics;

Member<string,bool> m=new Member<string, bool>();

m.Name="Raisa";
m.Is_Student=true;

Console.WriteLine(m.Name);
Console.WriteLine(m.Is_Student);