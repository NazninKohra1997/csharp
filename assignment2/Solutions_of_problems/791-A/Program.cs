int a1=1;
int a2=1;

for(int i=0;i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<2;j++){
        if(j==0){
            a1=int.Parse(num[j]);
        }
        else{
            a2=int.Parse(num[j]);
        }
    }
}

int sum=0;

while(a1<a2 || a1==a2){
    a1=a1*3;
    a2=a2*2;
    sum++;
}

Console.WriteLine(sum);