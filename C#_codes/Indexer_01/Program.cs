using Indexer_01;

Dictionary d = new Dictionary();

d.AddItems("Jhora", 101);
d.AddItems("Raisa", 102);


Console.WriteLine(d["Jhora",102]);
Console.WriteLine(d[102, "Raisa"]);

Console.WriteLine(d[11,"Jhora"]);