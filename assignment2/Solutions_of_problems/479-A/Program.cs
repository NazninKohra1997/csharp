int a=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());
int c=int.Parse(Console.ReadLine());

int Max=a+b+c;

int[] arr=new int[5];

arr[0]=a*b*c;
arr[1]=(a+b)*c;
arr[2]=a*(b+c);
arr[3]=a+(b*c);
arr[4]=(a*b)+c;

for(int i=0;i<5;i++){
    if(arr[i]>Max){
        Max=arr[i];
    }
}

Console.WriteLine(Max);