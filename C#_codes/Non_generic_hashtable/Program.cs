using System.Collections;

Hashtable h = new Hashtable();

h.Add("Jhora", 25);
h.Add("Tipu", 27);
h.Add("Raisa", 18);

foreach(DictionaryEntry i in h)
{
    Console.WriteLine($"{i.Key},{i.Value}");
}