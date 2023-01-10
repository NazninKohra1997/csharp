var a=new int[1,2];
for(int i=0;i<1;i++){
    var n=new string[1];
    n=Console.ReadLine().Split();
    for(int j=0;j<2;j++){
        a[i,j]=int.Parse(n[j]);
    }
}

var arr=new int[1,a[0,0]];

for(int i=0; i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<a[0,0];j++){
        arr[i,j]=int.Parse(num[j]);
    }
}


int position=arr[0,a[0,1]-1];
//int length=arr.Length;

int length=0;


for(int i=0;i<1;i++){
    for(int j=0;j<a[0,0];j++){
        if((arr[i,j]==position || arr[i,j]>position) && arr[i,j]>0){
            length=length+1;
        }
    }
}




Console.WriteLine(length);