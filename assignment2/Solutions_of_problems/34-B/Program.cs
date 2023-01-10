int n=0;
int m=0;

for(int i=0;i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<2;j++){
        if(j==0){
            n=int.Parse(num[j]);
        }
        else{
            m=int.Parse(num[j]);
        }
    }
}

int[] a=new int[n];
for(int i=0;i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<n;j++){
    a[j]=int.Parse(num[j]);
}
}

for(int i=0;i<a.Length;i++){
    for(int j=i+1;j<a.Length;j++){
   // Console.WriteLine(a[i]);
   if(i==a.Length-1){
    break;
   }
   if(a[i]>a[j]){
    int temp=a[i];
    a[i]=a[j];
    a[j]=temp;
   }
   
}
}

int s=0;

for(int i=0;i<m;i++){
    if (a[i] >= 0)
        {
            break;
        }
        s += a[i];
}

Console.WriteLine(-s);