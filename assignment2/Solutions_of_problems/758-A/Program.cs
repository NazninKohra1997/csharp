int number=int.Parse(Console.ReadLine());
int[] arr=new int[number];

for(int i=0;i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<number;j++){
         arr[j]=int.Parse(num[j]);
    }
}


int Max=0;
for(int i=0;i<arr.Length;i++){
    //Console.WriteLine(arr[i]);
    if(arr[i]>Max){
        Max=arr[i];
    }
}
int sum=0;

for(int i=0;i<arr.Length;i++){
    sum+=Max-arr[i];
}

Console.WriteLine(sum);