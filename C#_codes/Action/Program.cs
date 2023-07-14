using Action;

Actions action = new Actions();
action.Item3 = 5;
action.Item4 = 6;

action.Printer2(Multiply);

void Multiply(int a, int b)
{
    int x = a * b;
    Console.WriteLine(x);
}