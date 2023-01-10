int[] arr=new int[4];

for(int i=0;i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<4;j++){
        arr[j]=int.Parse(num[j]);
    }
}

/*for(int i=0;i<arr.Length;i++){
    Console.WriteLine(arr[i]);
}*/


for(int i=0;i<arr.Length;i++){
   for(int j=i+1;j<arr.Length;j++){
    if(arr[i]<arr[j]){
    int temp=arr[i];
    arr[i]=arr[j];
    arr[j]=temp;
    }  
}
}

int count=0;

for(int i=0;i<arr.Length;i++){
    //Console.WriteLine(arr[i]);
    if(arr[i]==arr[i+1]){
        count++;
    }
    if(i==2){
        break;
    }
}

Console.WriteLine(count);