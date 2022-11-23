void PrimeNumber(int number){
    if(number<2){
        Console.WriteLine("Not prime");
    }
    else{
        int sum=0;
        for(int i=2;i<=number/2;i++){
            if(number%i==0){
               Console.WriteLine("Not prime");
               sum=1;
               break;
            }
        }

        if(sum==0){
            Console.WriteLine("prime");
        }
    }
}


int num=int.Parse(Console.ReadLine());

PrimeNumber(num);