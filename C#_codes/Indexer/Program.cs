using Indexer;
using System.Xml;

KeyBoard k = new KeyBoard();

k.Output("A", 105);
k.Output("B", 603);

Console.WriteLine(k["A"]);
Console.WriteLine(k[105]);