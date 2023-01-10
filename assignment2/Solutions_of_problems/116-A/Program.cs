int number=int.Parse(Console.ReadLine());
var arr=new int[number,2];

for(int i=0;i<number;i++){
    var num=new string[number];
    num=Console.ReadLine().Split();

    for(int j=0;j<2;j++){
        arr[i,j]=int.Parse(num[j]);
    }
}

int sum=arr[0,0]+arr[0,1];
int max=sum;
//Console.WriteLine(sum);
Console.WriteLine();

int sum1=0;
int sum2=0;
//int[] arru=new int[number];
int Max=max;

for(int i=1;i<number;i++){
    for(int j=0;j<2;j++){
       if(j==0){
        //Console.WriteLine(arr[i,j]);
         sum1=sum-arr[i,j];
       }
       if(j==1){
        sum2=sum1+arr[i,j];
       }
    }
    sum=sum2;
    if(sum>Max){
        Max=sum;
    }
}


Console.WriteLine(Max);