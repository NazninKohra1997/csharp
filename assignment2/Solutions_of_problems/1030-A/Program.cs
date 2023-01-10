int number=int.Parse(Console.ReadLine());
int sum=0;

int[] arr=new int[number];

for(int i=0;i<1;i++){
    var num=new string[1];
     num=Console.ReadLine().Split();
    for(int j=0;j<number;j++){
        arr[j]=int.Parse(num[j]);
    }
}

for(int i=0;i<arr.Length;i++){
    //Console.WriteLine(arr[i]);
    sum+=arr[i];
}

if(sum==0){
    Console.WriteLine("EASY");
}
else{
    Console.WriteLine("HARD");
}
