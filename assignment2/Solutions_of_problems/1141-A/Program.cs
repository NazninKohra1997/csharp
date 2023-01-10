long n=0;
long m=0;
long sum=0;

for(int i=0;i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<2;j++){
        if(j==0){
            n=long.Parse(num[j]);
        }
        else{
            m=long.Parse(num[j]);
        }
    }
}

 if(n == m){
        Console.WriteLine("0");
    }
    else if(m % n != 0){
       Console.WriteLine("-1");
    }
    else{
        long d = m/n;
        while(d % 2 == 0){
            d /= 2;
            sum+=1;
        }
        while(d % 3 == 0){
            d /= 3;
           sum+=1;
        }
        if(d != 1){
            sum = -1;
        }
       Console.WriteLine(sum);
    }