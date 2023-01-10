long m=0,n=0,a=0;

for(int i=0;i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<3;j++){
        if(j==0){
           m=long.Parse(num[j]);
        }
        else if(j==1){
            n=long.Parse(num[j]);
        }
        else{
            a=long.Parse(num[j]);
        }
    }
}

long x,y;

if(m%a==0){
    x=m/a;
}
else{
    x=(m/a)+1;
}

if(n%a==0){
    y=n/a;
}
else{
    y=(n/a)+1;
}

long z=x*y;

Console.WriteLine(z);