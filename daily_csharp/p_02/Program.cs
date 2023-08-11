string[] names = new string[4];

for(int i=0;i<names.Length; i++)
{
    names[i] = Console.ReadLine();
}

Console.WriteLine();

foreach(var name in names)
{
    Console.WriteLine(name);
}