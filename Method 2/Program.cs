void IsPrime(int number){
    if(number<2){
        Console.WriteLine("Not prime!");
    }
    else{
        for(int i=2;i<=Math.Sqrt(number);i++){
            if(number%i==0){
                Console.WriteLine("Not prime!");
                break;
            }
            else{
                Console.WriteLine("Prime!");
                break;
            }
        }
    }
}

int num= int.Parse(Console.ReadLine());
IsPrime(num);