int n=int.Parse(Console.ReadLine());

int ans=0;

       while(n>1){
            if(n%2==0){
                n=n/2;
            }
            else
            {
                n=n-1;
                ans++;
                }
        }

Console.WriteLine(ans+1);