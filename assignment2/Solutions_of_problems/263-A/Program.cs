var arr=new int[5,5];

for(int i=0;i<5;i++){
    var num=new string[5];
    num=Console.ReadLine().Split();
    for(int j=0;j<5;j++){
        arr[i,j]= int.Parse(num[j]);
    }
}


int s=0;
for(int i=0;i<5;i++){
    for(int j=0;j<5;j++){
   
if(arr[i,j]==1){
    s+= Math.Abs((i+1)-3)+Math.Abs((j+1)-3);
}
//Console.WriteLine(arr[i,j]);
}
}

Console.WriteLine(s);