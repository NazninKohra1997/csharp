int[][][] arr=new int[2][][];

arr[0]=new int[2][];
arr[1]=new int[1][];

arr[0][0]=new int[2];
arr[0][1]=new int[1];

arr[1][0]=new int[1];


arr[0][0][0]=31;
arr[0][0][1]=23;

arr[0][1][0]=34;

arr[1][0][0]=36;

Console.WriteLine(arr[1][0][0]);