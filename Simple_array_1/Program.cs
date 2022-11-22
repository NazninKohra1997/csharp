int[] arr=new int[5]{1,2,3,4,5};

for(int i=0;i<arr.Length;i++){
    Console.WriteLine(arr[i]);
}


int[,] arr1=new int[3,2]{
         {1,2},
         {4,5},
         {3,6}
};

Console.WriteLine();

for(int i=0;i<3;i++){
    for(int j=0;j<2;j++){
        Console.WriteLine(arr1[i,j]);
    }
}

Console.WriteLine();

int[,] arr2=new int[1,3];
for(int i=0;i<1;i++){
    string[] num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<3;j++){
        arr2[i,j]=int.Parse(num[j]);
    }
}

for(int i=0;i<1;i++){
    for(int j=0;j<3;j++){
        Console.WriteLine(arr2[i,j]);
    }
}