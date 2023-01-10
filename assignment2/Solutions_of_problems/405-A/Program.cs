int number=int.Parse(Console.ReadLine());
int[] arr=new int[number];

for(int i=0;i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<number;j++){
       // Console.WriteLine(num[j]);
       arr[j]=int.Parse(num[j]);
    }
}

for(int i=0;i<arr.Length;i++){
    //Console.WriteLine(arr[i]);
    for(int j=i+1;j<arr.Length;j++){
        if(arr[i]>arr[j]){
            int temp=arr[i];
            arr[i]=arr[j];
            arr[j]=temp;
        }
    }
}

for(int i=0;i<arr.Length;i++){
    Console.Write(arr[i]);
    Console.Write(" ");
}