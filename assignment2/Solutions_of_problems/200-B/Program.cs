int num=int.Parse(Console.ReadLine());

double sum=0.000000000000;

int[] arr=new int[num];

for(int i=0;i<1;i++){
    var n=new string[1];
    n=Console.ReadLine().Split();
    for(int j=0;j<num;j++){
          sum+= int.Parse(n[j]);
    }
    
}

double d=sum/num;
Console.WriteLine(d);
