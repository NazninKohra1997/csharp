LinkedList<string> llist = new LinkedList<string>();

llist.AddFirst("Jhora");
var r=llist.AddLast("raisa");
var r1=llist.AddBefore( r,"raina");
llist.AddAfter(r1, "Musaib");


foreach(var i in llist)
{
    Console.WriteLine(i);
}