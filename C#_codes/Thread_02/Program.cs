

Thread t1 = new Thread(() => Even(200));
Thread t2 = new Thread(() => Odd(200));

t1.Start();
t2.Start();




void Even(int item)
{
    for(int i=0; i<=item; i += 2)
    {
        Console.WriteLine(i);
    }
}


void Odd(int item)
{
    for (int i = 1; i <= item; i += 2)
    {
        Console.WriteLine(i);
    }
}