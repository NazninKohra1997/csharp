int number=int.Parse(Console.ReadLine());
int m=0;
int n=0;

for(int k=0;k<number;k++){
    for(int i=0;i<1;i++){
        var num=new string[1];
        num=Console.ReadLine().Split();
        for(int j=0;j<2;j++){
             if(j==0){
                m=int.Parse(num[j]);
             }
             else{
                n=int.Parse(num[j]);
             }
        }
    }

    if(m%n==0){
        Console.WriteLine("YES");
    }
    else{
        Console.WriteLine("NO");
    }
}