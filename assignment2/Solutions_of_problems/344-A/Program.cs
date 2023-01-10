
int sum=0;
int number=int.Parse(Console.ReadLine());
int[] arr=new int[number];

for(int i=0;i<number;i++){
      arr[i]=int.Parse(Console.ReadLine());
}


for(int i=0; i<number; i++){
   if(i==number-1){
    break;
   }
    else{
        if(arr[i]!=arr[i+1]){
            sum++;
    }
    }
}
   Console.WriteLine(sum+1);