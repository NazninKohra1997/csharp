int[] arr = new int[5] { 55, 45, 99, 76, 101 };


for(int i=0; i<arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}


Console.WriteLine();


for(int i=0; i<arr.Length ; i++)
{
    while (i < 5)
    {
        int a = arr[i] + 1;
        Console.WriteLine(a);
        break;
    }
}

Console.WriteLine();


for(int i=0;i<arr.Length ; i++)
{
   
    do{
       int j = arr[i] + 2;
        Console.WriteLine(j);
        break;
    } while (i < 5);
   
  

}


Console.WriteLine();

foreach(var a in arr)
{
    Console.WriteLine(a);
}