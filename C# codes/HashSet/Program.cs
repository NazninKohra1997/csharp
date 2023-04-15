HashSet<string> hash = new HashSet<string>(); // for storing unique values

hash.Add("Jhora");
hash.Add("Raisa");
hash.Add("Raina");
hash.Add("Jhora");

foreach(var i in hash)
{
    Console.WriteLine(i);
}