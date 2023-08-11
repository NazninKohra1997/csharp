int[] ages = new int[5];

for(int i=0; i<ages.Length; i++)
{
    ages[i] = int.Parse(Console.ReadLine());
}


Console.WriteLine();

foreach(var age in ages)
{
    Console.WriteLine(age);
}