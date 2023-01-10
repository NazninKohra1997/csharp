string s1=Console.ReadLine();
string s2="";

for(int i=s1.Length-1; i>=0; i--){
   // Console.WriteLine(s1[i]);
    s2+=s1[i];
}


//Console.WriteLine(s2);
string t=Console.ReadLine();

if(t==s2){
    Console.WriteLine("YES");
}
else{
    Console.WriteLine("NO");
}