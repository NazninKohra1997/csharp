Thread t1 = new Thread(PrintEven);
Thread t2 = new Thread(PrintOdd);

t1.Start();
t2.Start();
//PrintOdd();


//PrintEven();
//Console.WriteLine();
//PrintOdd();         Doesn't work parallely


void PrintEven()
{
    for(int i=0; i<=20; i += 2)
    {
        Console.WriteLine(i);
    }
}

void PrintOdd()
{
    for(int i=1 ;i<=19; i+= 2)
    {
        Console.WriteLine(i);
    }
}