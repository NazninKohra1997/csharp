int sum=0;
int c=0;
int res=0;
int n=0;
int k=0;


for(int i=0;i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<2;j++){
        if(j==0){
        n=int .Parse(num[j]);
        }
        else{
            k=int.Parse(num[j]);
            res=240-k;
        }
        
    }
     for (i=1; i<=n; i++)
        {
            sum += 5 * i;

            if (sum > res)
                break;

            c = c + 1;
        }
}

Console.WriteLine(c);