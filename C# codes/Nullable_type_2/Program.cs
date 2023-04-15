int? x = null;

x = 5;

if (x.HasValue)
{
    Console.WriteLine(x.Value);
}
else
{
    Console.WriteLine("Not assigned!");
}
