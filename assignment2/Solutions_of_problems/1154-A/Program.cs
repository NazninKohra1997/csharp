var arr=new int[1,4];
int[] arru=new int[4];

for(int i=0;i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<4;j++){
        arr[i,j]=int.Parse(num[j]);
        arru[j]=arr[i,j];
    }
}


int Max=0;
for(int i=0;i<arru.Length;i++){
    //Console.WriteLine(arru[i]);
    if(arru[i]>Max){
        Max=arru[i];
    }
}

//Console.WriteLine(Max);


int sub;
for(int i=0;i<arru.Length;i++){
   sub= Max-arru[i];
   if(sub!=0){
    Console.WriteLine(sub);
   }
}
