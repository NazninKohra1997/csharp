using Func_and_Action;

Func func = new Func();

func.Item1 = 5;
func.Item2 = 5;
func.Printer(Sum);

int Sum(int a, int b)
{
    return a + b;
}

