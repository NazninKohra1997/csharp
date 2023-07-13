
using Delegate_01;

Printer printer = new Printer();
printer.Item01 = 5;
printer.Item02 = 6;

printer.print(Sum);
printer.print(Multiplication);

int Sum(int a,int b)
{
    return a + b;
}

int Multiplication(int a,int b)
{
    return (a * b);
}