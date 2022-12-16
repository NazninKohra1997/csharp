using System.Collections;
ArrayList arr=new ArrayList();

for(int i=0;i<7;i++){
    string s= Console.ReadLine();
    arr.Add(s);
}
Console.WriteLine();

foreach(var a in arr){
    Console.WriteLine(a);
}
