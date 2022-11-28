HashSet<string> set=new HashSet<string>();

set.Add("Raisa");
set.Add("Raina");
set.Add("Raisa");

foreach(var s in set){
    Console.WriteLine(s);
}
Console.WriteLine();


HashSet<int> roll=new HashSet<int>();

for(int i=0;i<5;i++){
    int num=int.Parse(Console.ReadLine());
    roll.Add(num);
}
Console.WriteLine();

foreach(var i in roll){
    Console.WriteLine(i);
}