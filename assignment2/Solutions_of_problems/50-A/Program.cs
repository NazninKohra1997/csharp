int sum=1;


for(int i=0;i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<2;j++){
        
        sum= sum * int.Parse(num[j]);
    }
}


int x=sum/2;
Console.WriteLine(x);