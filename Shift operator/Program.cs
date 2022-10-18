uint m= 0b_1111_0001_1100_0001;
Console.WriteLine(Convert.ToString(m,toBase:2));

//Left shift
uint y= m<<2;
Console.WriteLine(Convert.ToString(y,toBase:2));
Console.WriteLine("\n");

//Right shift
uint z= m>>3;
Console.WriteLine(Convert.ToString(m,toBase:2));
Console.WriteLine(Convert.ToString(z,toBase:2));