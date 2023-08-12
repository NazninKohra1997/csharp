int[,] ages = new int[2, 3];

for(int i=0; i<2; i++)
{
    for(int j=0; j < 3; j++)
    {
        ages[i, j] = int.Parse(Console.ReadLine());
    }
}


Console.WriteLine();

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(ages[i, j]);
        if (i == 1 && j == 2)
        {
            Console.Write("");
        }
        else
        {
            Console.Write(",");
        }
    }
    Console.WriteLine();
}