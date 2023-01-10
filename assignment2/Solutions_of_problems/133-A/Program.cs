string st1="HQ9";
string st2=Console.ReadLine();

string ss="";

for(int i=0;i<st1.Length;i++){
    if(ss=="YES"){
        break;
    }
    for(int j=0;j<st2.Length;j++){
       if(st1[i]==st2[j]){
          ss="YES";
          break;
        }
        else{
            ss="NO";
        }
    }
}


Console.WriteLine(ss);