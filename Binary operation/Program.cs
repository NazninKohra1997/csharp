uint a=0b_1111_1000;
uint b = 0b_1001_1101;

//and operation
uint x= a & b;
Console.WriteLine(Convert.ToString(x,toBase:2));


//or operation
uint y= a | b;
Console.WriteLine(Convert.ToString(y,toBase:2)); 

//xOR operation
uint z= a ^ b;
Console.WriteLine(Convert.ToString(z,toBase:2));