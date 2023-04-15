Dictionary<string, int> ages = new Dictionary<string, int>();

ages.Add("Jhora", 25);
ages.Add("Raisa", 18);
ages.Add("Raina", 15);

foreach(var i  in ages)
{
    Console.WriteLine($"{i.Key},{i.Value}");
}

Console.WriteLine();

Console.WriteLine(ages["Raisa"]);

Console.WriteLine();

ages.Remove("Jhora");

foreach(var i in ages)
{
    Console.WriteLine($"{ i.Key}, {i.Value}");
}