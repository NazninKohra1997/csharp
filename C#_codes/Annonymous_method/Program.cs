/*int sum(int a,int b)
{
    return a + b;
}*/


Func<int, int, int> something = (a,b) => a+b;

int sum = something(5, 6);
Console.WriteLine(sum);