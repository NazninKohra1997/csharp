int [,] arr=new int[3,3] {{1,2,3},{4,5,6},{7,8,9}};
arr[0,0]=1;
arr[0,1]=2;
arr[1,1]=3;

arr[1,0]=4;
arr[1,1]=5;
arr[1,2]=6;

arr[2,0]=7;
arr[2,1]=8;
arr[2,2]=9;


Console.WriteLine(arr[1,1]);
Console.WriteLine(arr[2,2]);
Console.WriteLine(arr[1,2]);

