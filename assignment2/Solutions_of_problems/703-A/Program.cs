int number=int.Parse(Console.ReadLine());

int sum1=0;
int sum2=0;

int a=1;
int b=1;

for(int i=0;i<number;i++){
    for(int j=0;j<1;j++){
        var num=new string[1];
        num=Console.ReadLine().Split();
        for(int k=0;k<2;k++){
            if(k==0){
                a=int.Parse(num[k]);
            }
            else{
                 b=int.Parse(num[k]);
            }
        }
        
    }
    if(a>b){
            sum1++;
        }
        else if(a<b){
            sum2++;
        }
}


if(sum1>sum2){
    Console.WriteLine("Mishka");
}
else if(sum2>sum1){
    Console.WriteLine("Chris");
}
else{
    Console.WriteLine("Friendship is magic!^^");
}