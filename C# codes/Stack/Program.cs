Stack<string> s = new Stack<string>();

s.Push("Apple");
s.Push("Mango");
s.Push("Banana");
s.Push("Orange");

foreach(var i  in s)
{
    Console.WriteLine(i);
}

Console.WriteLine();

s.Pop();
s.Pop();

foreach (var i in s)
{
    Console.WriteLine(i);
}

Console.WriteLine();

s.Peek();
foreach (var i in s)
{
    Console.WriteLine(i);
}
