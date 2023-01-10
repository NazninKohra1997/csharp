int[] arr=new int[3];

for(int i=0;i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<3;j++){
        string s= num[j].ToString();
        arr[j]=int.Parse(s);
    }
}

int m=arr[0];
int sum=0;
int n=arr[arr.Length-1];

for(int i=1;i<=n;i++){
   // Console.WriteLine(i);
   sum+=m*i;
}

//Console.WriteLine(sum);

int z=sum-arr[1];

if(arr[1]>sum){
    Console.WriteLine('0');
}
else{
Console.WriteLine(Math.Abs(z));
}