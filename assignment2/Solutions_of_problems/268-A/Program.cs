int num=int.Parse(Console.ReadLine());

int[] arr1= new int[num];

int[] arr2= new int[num];
int sum=0;

int count=0;

for(int i=0;i<num;i++){
    for(int k=0;k<1;k++){
        var num1= new string[1];
        num1=Console.ReadLine().Split();
        for(int j=0;j<2;j++){
            if(j==0){
                arr1[count]=int.Parse(num1[j]);
            }
            else if(j==1){
                arr2[count]=int.Parse(num1[j]);
            }
            
        }
    }

    count++;
    //Console.WriteLine(count);
}


for(int i=0;i<arr1.Length;i++){
    for(int j=0;j<arr2.Length;j++){
        if(arr1[i]==arr2[j]){
            sum+=1;
        }

    }
}

Console.WriteLine(sum);