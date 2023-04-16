using System.Collections;

Stack s = new Stack();

s.Push(3);
s.Push(4);
s.Push("Jhora");
s.Push(32);

foreach(var i in s)
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



