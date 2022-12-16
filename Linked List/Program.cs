LinkedList<string> llist= new LinkedList<string>();

for(int i=0;i<7;i++){
    string s=Console.ReadLine();
    llist.AddLast(s);
}

Console.WriteLine();


foreach(var a in llist){
    Console.WriteLine(a);
}