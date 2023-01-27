using Event;

Do d=  new Do();

d.Done+= (a) => Console.WriteLine(a);

d.DoWork();