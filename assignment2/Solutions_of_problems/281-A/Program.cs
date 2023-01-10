string s=Console.ReadLine();

string st=s.ToUpper();

//Console.WriteLine(st[0]);

string s1="";


for(int i=1;i<s.Length;i++){
   // Console.WriteLine(s[i]);
   s1+=s[i];
}

//Console.WriteLine(s1);

string ss=st[0]+s1;
Console.WriteLine(ss);