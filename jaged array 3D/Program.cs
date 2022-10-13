int[][][] arr= new int[2][][];

arr[0] = new int[2][];
arr[1]=new int[3][];

arr[0][0]=new int[2];
arr[0][1]=new int[3];

arr[1][0]=new int[3];
arr[1][1]=new int[2];
arr[1][2]=new int[1];

arr[0][0][0]=3;
arr[0][0][1]=2;

arr[0][1][0]=4;
arr[0][1][1]=2;
arr[0][1][2]=5;

arr[1][0][0]=2;
arr[1][0][1]=7;
arr[1][0][2]=5;

arr[1][1][0]=7;
arr[1][1][1]=9;

arr[1][2][0]=11;


Console.WriteLine(arr[0][0][1]);
Console.WriteLine(arr[1][0][1]);
Console.WriteLine(arr[1][2][0]);