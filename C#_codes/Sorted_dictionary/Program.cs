SortedDictionary<int, string> Sdict = new SortedDictionary<int, string>();

Sdict.Add(37, "Symum");
Sdict.Add(25, "Jhora");
Sdict.Add(15, "Raisa");
Sdict.Add(40, "Mimi");

foreach(var i in Sdict)
{
    Console.WriteLine($"{i.Key},{i.Value}");
}