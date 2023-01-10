int even=0;
int lastodd=0;
int lasteven=0;

int n=int.Parse(Console.ReadLine());

for(int i=0;i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<n;++j){
        int x=int.Parse(num[j]);
        if (x % 2 == 0)
        {
            even += 1;
            lasteven = j;
        }
        else
        {
            even -= 1;
            lastodd = j;
        }
    }
}

lasteven=lasteven+1;
lastodd=lastodd+1;

if(even>0){
    Console.WriteLine(lastodd);
}
else{
    Console.WriteLine(lasteven);
}