void IsPrime(int number)
{
    bool flag = true;

    if (number < 2)
    {
        Console.WriteLine("Not prime!");
    }

    else
    {
        for(int i=2; i<=number/2; i++)
        {
            if(number%i == 0)
            {
                flag = false;
                break;
            }
        }

        if (flag == false)
        {
            Console.WriteLine("Not prime!");
        }
        else
        {
            Console.WriteLine("Prime!");
        }
    }
}


for(int i=1; i<=100; i++)
{
    Console.WriteLine(i);
    IsPrime(i);
    Console.WriteLine();
}