int a=1;
int b=1;

for(int i=0;i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<2;j++){
        if(j==0){
            a=int.Parse(num[j]);
        }
        else{
            b=int.Parse(num[j]);
        }
    }
}

if(a>b){
    int x=(a-b)/2;
    Console.Write(b);
    Console.Write(" ");
    Console.WriteLine(x);
}

else{
    Console.Write(a);
    Console.Write(" ");
    int y=(b-a)/2;
    Console.WriteLine(y);
}