List<string> list=new List<string> ();

list.Add("Dhaka");
list.Add("Khulna");
list.Add("Sylhet");

//list.Remove("Dhaka");

foreach(var i in list ){
    Console.WriteLine(i);
}


Console.WriteLine();

List<string> Number= new List<string>();



for(int i=0;i<5;i++){
    string s=Console.ReadLine();
    Number.Add(s);
}

Console.WriteLine();

for(int i=0;i<Number.Count;i++){
    Console.WriteLine(Number[i]);
} 


Console.WriteLine();
List<int> roll=new List<int>();
for(int i=0;i<5;i++){
    int num=int.Parse(Console.ReadLine());
    roll.Add(num);
}

Console.WriteLine();

for(int i=0;i<roll.Count;i++){
    Console.WriteLine(roll[i]);
}