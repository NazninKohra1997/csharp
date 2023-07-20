using Operator_overloading;

Fraction f1 = new Fraction();
f1.Num = 2;
f1.Den = 3;

Fraction f2 = new Fraction();
f2.Num = 6;
f2.Den = 7;

var sum = f1+f2;

Console.WriteLine($"{sum.Num}  {sum.Den}");