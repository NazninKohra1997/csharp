
void Value(params double[] values )
{
    double s = 0;
    foreach (var v in values)
    {
         s+= v;
    }
    Console.WriteLine(s);
}

Value(1, 2, 3, 4, 5);


void Value1(in int v1)
{
    //v1 = 4; error 
    int v8 = 27;
    Console.WriteLine(v1);
}

Value1(7);

void Value2(out int v2)
{
    v2 = 4;
    Console.WriteLine(v2);
}

int s1 = 10;
Value2(out s1);

void Value3(ref int v3)
{
    v3 = 5;
    Console.WriteLine(v3);
}

int s2 = 11;
Value3(ref s2);