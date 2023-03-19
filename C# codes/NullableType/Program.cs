

int? x = null;

if (x.HasValue)
{
    Console.WriteLine(x.Value);
}
else
{
    Console.WriteLine("No value");
}