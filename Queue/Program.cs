Queue<string> qu=new Queue<string>();

string[] arr= new string[5] {"Raisa","Raina","Dhaka","Khulna","turkey"};

for(int i=0;i<arr.Length;i++){
    qu.Enqueue(arr[i]);
}

string st=qu.Peek();
Console.WriteLine(st);
Console.WriteLine();

for(int i=0;i<2;i++){
    qu.Dequeue();
}

foreach(var s in qu){
    Console.WriteLine(s);
}