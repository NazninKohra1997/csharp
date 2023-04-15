SortedList<string, int> sl = new SortedList<string, int>();

sl.Add("Jhora", 25);
sl.Add("Raisa", 18);
sl.Add("Tipu", 28);
sl.Add("Raina", 15);

foreach(var i in sl)
{
    Console.WriteLine($"{i.Key},{i.Value}");
}