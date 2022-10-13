int [,] arr= new int[3,2]{{1,2},
                           {2,2},
                           {3,2}};

arr[0,0]=1;
arr[0,1]=2;
arr[1,0]=2;
arr[1,1]=3;
arr[2,0]=2;

Console.WriteLine(arr[0,1]);
Console.WriteLine(arr[2,0]);