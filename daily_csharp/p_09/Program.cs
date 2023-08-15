void IsPrime(int number)
{
    bool flag = true;

    if (number < 2)
    {
        Console.WriteLine("Not Prime");
    }

    else
    {
        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                flag = false;
                break;
            }

        }


        if (flag == true)
        {
            Console.WriteLine("Prime");
        }
        if (flag == false)
        {
            Console.WriteLine("Not prime");
        }
    }
}


for(int i=1; i <= 20; i++)
{
    Console.WriteLine(i);
    
    IsPrime(i);
    Console.WriteLine();
}