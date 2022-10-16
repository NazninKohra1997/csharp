//For integer
uint m= 5;
Console.WriteLine(Convert.ToString(m,toBase:2));

m=~m;
Console.WriteLine(Convert.ToString(m,toBase:2));

Console.WriteLine("\n");


//For binary
uint t= 0b_0000_1111_0000_1111_0000_1100;
t=~t;
Console.WriteLine(Convert.ToString(t,toBase:2));

Console.WriteLine("\n");


//For hexadecimal
uint h=0x_AF09;
Console.WriteLine(Convert.ToString(h,toBase:16));
h=~h;
Console.WriteLine(Convert.ToString(h,toBase:16));

Console.WriteLine("\n");


