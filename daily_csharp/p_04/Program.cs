string[,] names = new string[3, 2];


for(int i=0; i<3; i++)
{
    for(int j=0;j<2; j++)
    {
        names[i,j] = Console.ReadLine();
    }
}


Console.WriteLine();

for(int i=0; i < 3; i++)
{
    for (int j=0; j<2; j++)
    {
        Console.Write(names[i,j]);
        if (i == 2 && j == 1)
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