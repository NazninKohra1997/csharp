int[] arr=new int[5] {100,20,10,5,1};

int sum=0;

int num=int.Parse(Console.ReadLine());

for(int i=0;i<arr.Length;i++){
    sum+=num/arr[i];
    num=num%arr[i];
   // Console.WriteLine(sum);
}

Console.WriteLine(sum);
