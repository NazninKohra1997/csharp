using genericsExample;

Coordinate<int> co = new Coordinate<int>();
co.X=4;
Coordinate<double> cor =new Coordinate<double>();
cor.Y=9.5;
Console.WriteLine(co.X);
Console.WriteLine(cor.Y);
Console.WriteLine();


Generics2<int> gene=new Generics2<int> ();
gene.Number=101;
Console.WriteLine(gene.Number);
Console.WriteLine();


Generics3<Person> gener=new Generics3<Person> ();
gener.ID=new Person();
Person p=gener.ID;
p.id=102;
Console.WriteLine(p.id);
Console.WriteLine();


Puzzle<string,int,string> puz1=new Puzzle<string, int, string>();
puz1.Color="Red";
puz1.Name="Rubics Qube";
puz1.Number=101;
Console.WriteLine(puz1.Color);
Console.WriteLine(puz1.Name);
Console.WriteLine(puz1.Number);
Console.WriteLine();
