using Linq;



Teacher[] teacher = new Teacher[2];

teacher[0] = new Teacher
{
    Name = "Raisa",
    Id = 11
};

teacher[1] = new Teacher
{
    Name = "Raina",
    Id = 4
};

var data = from t in teacher where t != null && t.Id > 5 select t;

foreach(var d in data)
{
    Console.WriteLine(d.Name);
    Console.WriteLine(d.Id);
}


Console.WriteLine();

var data1 = teacher.Where(x => x != null && x.Id < 5);

foreach(var d1 in data1)
{
    Console.WriteLine(d1.Name);
    Console.WriteLine(d1.Id);
}

