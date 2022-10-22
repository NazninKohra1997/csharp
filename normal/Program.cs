//taking number for inputs
Console.WriteLine("Enter the number of inputs:");
int num= int.Parse(Console.ReadLine());



int number;
int Max1=0;
int Max2=0;
int Max3=0;

//taking inputs
Console.WriteLine("Enter the inputs:");
for(int i=0;i<num;i++){
    number=int.Parse(Console.ReadLine());

   //Finding largest number 
   
   if(number>Max1){
     Max3=Max2;
    Max2=Max1;
     Max1=number;
   }

   //Finding 2nd largest number
   else if(number>Max2 && number<Max1){
        
         Max2=number;
   }

   //Finding 3rd largest number
  else if(number>Max3 && number<Max2){
    Max3=number;
   }
}

Console.WriteLine("The 3rd largest number is:");
Console.WriteLine(Max3);