int num=int.Parse(Console.ReadLine());

for(int i=0;i<num;i++){
    int n=int.Parse(Console.ReadLine());
    if( n == 2){
        Console.WriteLine("2");
    }
        
         else if (n %2 == 0 && n > 2){
            Console.WriteLine("0");
         }
             
            

            else{
                Console.WriteLine("1");
            }

}