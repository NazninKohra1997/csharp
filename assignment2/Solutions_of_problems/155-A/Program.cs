int n=int.Parse(Console.ReadLine());
int[] arr=new int[n];

int min=10000;
int  a=0;
int max=0;
int b=0; 
int c=0;

for(int i=0;i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<n;j++){
        arr[j]=int.Parse(num[j]);
    }
}


for(int i=0;i<arr.Length;i++){
    if (max<arr[i]){
        max=arr[i];
        a+=1;
    }    
    if(min>arr[i]){
        min=arr[i];
        b+=1;
    }
}

c=a+b-2;

if(a+b==n && max!=min){
    Console.WriteLine(n-1);
}
else{
    if(c<0 ){
        Console.WriteLine("0");
    }
    else{
        Console.WriteLine(c);
    }
}

//Console.Write(a);
//Console.Write(" ");
//Console.Write(c);

