int n=int.Parse(Console.ReadLine());

int people=0;
int capacity=0;
int c=0;


for(int l=0;l<n;l++){
for(int i=0;i<1;i++){
    var num=new string[n];
    num=Console.ReadLine().Split();
    for(int j=0;j<2;j++){
        if(j==0){
            people=int.Parse(num[j]);
        }
        else{
            capacity=int.Parse(num[j]);
        }
    }
   
        if(capacity-people>=2){
            c++;
        }
}


}

Console.WriteLine(c);