List<int> list = new List<int>();

list.Add(2);
list.Add(24);
list.Add(45);

foreach(var l in list)
{
    Console.WriteLine(l);
;
}


list.Remove(2);

Console.WriteLine();

foreach (var l in list)
{
    Console.WriteLine(l);
    ;
}