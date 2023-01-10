int k=int.Parse(Console.ReadLine());
int l=int.Parse(Console.ReadLine());
int m=int.Parse(Console.ReadLine());
int n=int.Parse(Console.ReadLine());
int d=int.Parse(Console.ReadLine());

int cont=d;


if(k == 1 || l == 1 || m == 1 || n == 1)
    {
        Console.WriteLine(d);
    }
    else
    {
        for(int i = 1; i <= d; i++)
        {
            if((i%k != 0) && (i%l != 0) && (i%m != 0) && (i%n != 0))
                cont--;
        }
        Console.WriteLine(cont);
    }