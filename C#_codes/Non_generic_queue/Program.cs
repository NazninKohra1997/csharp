using System.Collections;

Queue q = new Queue();

q.Enqueue(33);
q.Enqueue(44);
q.Enqueue("Jhora");
q.Enqueue(7);

foreach(object i in q)
{
    Console.WriteLine(i);
}

Console.WriteLine();

q.Dequeue();
q.Dequeue();

foreach (object i in q)
{
    Console.WriteLine(i);
}