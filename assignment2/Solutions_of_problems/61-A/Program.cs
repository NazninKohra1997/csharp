string s1=Console.ReadLine();
string s2=Console.ReadLine();

string result="";

for(int i=0;i<s1.Length;i++){
    if(s1[i]==s2[i]){
           result+='0';
    }
    else{
        result+='1';
    }
}

Console.WriteLine(result);
