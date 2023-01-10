var arr=new int[1,2];

for(int i=0;i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<2;j++){
        arr[i,j]=int.Parse(num[j]);
    }
}

int sum=0;
int sum1=0;

for(int i=0;i<arr[0,0];i++){
    sum+=1;
    if(sum%2==1){
        for(int j=0;j<arr[0,1];j++){
            Console.Write("#");
        }
    }
    else if(sum%2==0){
        sum1+=1;
        if(sum1%2==1){
            for(int k=0;k<arr[0,1]-1;k++){
                Console.Write(".");
            }
            Console.Write("#");
        }
         else if(sum1%2==0){
             Console.Write("#");
            for(int l=0;l<arr[0,1]-1;l++){
                Console.Write(".");
            }
        
        }
    }
    Console.WriteLine();
}