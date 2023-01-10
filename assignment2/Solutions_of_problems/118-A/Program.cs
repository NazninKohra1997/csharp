string s=Console.ReadLine();
string t="";

string result;
	for(int i=0;i<s.Length;i++){
	    string c=(s[i]).ToString();
        string ch=c.ToLower();

	    if(ch=="a" || ch=="e" || ch=="i" || ch=="o" || ch=="u" || ch=="y"){
	       continue; 
	    }
        else{
	       t="."+ch;
           Console.Write(t);
	    }
	}
	