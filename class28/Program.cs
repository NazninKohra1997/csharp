using TupleExample;

Person p=new Person("Rahim",10);

(int Id,int Roll)r= new(p.Id,p.Roll);

Console.WriteLine(r.Id);
Console.WriteLine(r.Roll);

