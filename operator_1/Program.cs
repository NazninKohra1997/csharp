int x=5;
x=~x;
Console.WriteLine(Convert.ToString(x,toBase:2));

Console.WriteLine();
uint y=0b_0000_1111_1010;
y=~y;
Console.WriteLine(Convert.ToString(y,toBase:2));

Console.WriteLine();
int z=10;
string message= z==5? "Z is 5":"z not 5";
Console.WriteLine(message);
