int a=0;
int b=0;
int c=0;
int d=0;

for(int i=0;i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<4;j++){
         if(j==0){
            a=int.Parse(num[j]);
         }
         if(j==1){
            b=int.Parse(num[j]);
         }
         if(j==2){
            c=int.Parse(num[j]);
         }
         if(j==3){
            d=int.Parse(num[j]);
         }
    }
}



if(a==b+c+d || b==a+c+d || c==a+b+d || d==a+b+c || a+b==c+d || a+c==b+d || a+d==b+c){
    Console.WriteLine("YES");
}
else{
    Console.WriteLine("NO");
}
