SortedList<string,int> roll = new SortedList<string,int>();

roll.Add("Raisa",2);
roll.Add("Raina",36);
roll.Add("Ahora",22);

foreach(var i in roll){
    Console.Write(i.Key);
    Console.Write(",");
    Console.WriteLine(i.Value);
}

Console.WriteLine();

SortedDictionary<int,int> number=new SortedDictionary<int, int>();

number.Add(34,22);
number.Add(100,23);
number.Add(10,56);

foreach(var d in number){
    Console.Write(d.Key);
    Console.Write(",");
    Console.WriteLine(d.Value);
}
Console.WriteLine();


SortedSet<int> set=new SortedSet<int>();

set.Add(22);
set.Add(36);
set.Add(2);

foreach(var s in set){
    Console.WriteLine(s);
}