int n=int.Parse(Console.ReadLine());
int e=0;
int p=0;
int c=0;

for(int i=0;i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<n;j++){
           e=int.Parse(num[j]);
           if(e == -1)
        {
            if(p > 0)
                p--;
            else
                c++;
        }
        else
            p += e;
    }

    
    
}

Console.WriteLine(c);