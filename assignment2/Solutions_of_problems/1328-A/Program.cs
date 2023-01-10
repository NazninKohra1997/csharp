int n1=int.Parse(Console.ReadLine());
int a=0,b=0;
int s;



for(int i=0;i<n1;i++){
    for(int j=0;j<1;j++){
        var num=new string[1];
        num=Console.ReadLine().Split();
        for(int k=0;k<2;k++){
         s=int.Parse(num[k]);
           if(k==0){
            a=s;
           }
           else{
            b=s;
           }
        }
    }
   // Console.Write(a);
    //Console.Write("  ");
    //Console.WriteLine(b);

    if(a%b==0){
       Console.WriteLine("0");
    }
    else{
        int f= b-(a%b);
        Console.WriteLine(f);
    }
}