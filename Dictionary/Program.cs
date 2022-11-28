Dictionary<string,string> name= new Dictionary<string, string>();

name.Add("Raisa","one");
name.Add("Raina","two");

foreach(var n in name){
    Console.Write(n.Key);
    Console.Write(",");
    Console.WriteLine(n.Value);
}