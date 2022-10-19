//taking input
int number = int.Parse(Console.ReadLine()); //converting string to int

//checking prime or not
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

//Console.WriteLine(Math.Sqrt(2));