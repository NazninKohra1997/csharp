//number1
Stack<string> location= new Stack<string>();
location.Push("Dhaka");
location.Push("Khulna");
location.Push("Sylhet");

foreach(var l in location){
    Console.WriteLine(l);
}
Console.WriteLine();

for(int i=0;i<2;i++){
    location.Pop();
}

foreach(var l in location){
    Console.WriteLine(l);
}
Console.WriteLine();


//number2
int[] arr= new int[7]{1,2,3,4,5,6,7};

Stack<int> number=new Stack<int>();

for(int i=0;i<arr.Length;i++){
    number.Push(arr[i]);
}


var state1=number.Peek();
Console.WriteLine(state1);
Console.WriteLine();

foreach(var n in number){
      Console.WriteLine(n);
}

