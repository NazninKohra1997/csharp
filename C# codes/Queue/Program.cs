Queue<string> q = new Queue<string>();   //first in first out

q.Enqueue("Water");
q.Enqueue("CocaCola");
q.Enqueue("Pepsi");
q.Enqueue("Sprite");

foreach(var i in q)
{
    Console.WriteLine(i);
}

Console.WriteLine();

q.Dequeue();
q.Dequeue();

foreach(var i in q)
{
    Console.WriteLine(i);
}