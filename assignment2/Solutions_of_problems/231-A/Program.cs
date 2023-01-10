int sum=0;
int sum2=0;
int number=int.Parse(Console.ReadLine());

for(int i=0;i<number;i++){
    var num=new string[number];
    num=Console.ReadLine().Split();
    for(int j=0;j<3;j++){
        sum+=int.Parse(num[j]);
       // Console.WriteLine(sum);
    }
    if(sum>2 || sum==2){
       sum2+=1;
    }
    sum=0;
}

Console.WriteLine(sum2);