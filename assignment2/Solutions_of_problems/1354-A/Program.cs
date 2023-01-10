int number=int.Parse(Console.ReadLine());
long a=0;
long b=0;
long c=0;
long d=0;
long sum=0;

for(int k=0;k<number;k++){
    
     for(int i=0;i<1;i++){
        var num=new string[1];
        num=Console.ReadLine().Split();
        for(int j=0;j<4;j++){
              if(j==0){
                a=long.Parse(num[j]);
              }
              if(j==1){
                b=long.Parse(num[j]);
              }
              if(j==2){
                c=long.Parse(num[j]);
              }
              if(j==3){
                d=long.Parse(num[j]);
              }
        }
     }
      if(b >= a){
        sum = b;
        }
        else if(c <= d){
            sum = -1;
            }
        else{
            a -= b; 
            sum = b + ((a + c - d - 1) / (c - d) * c);
        }

       Console.WriteLine(sum);
}