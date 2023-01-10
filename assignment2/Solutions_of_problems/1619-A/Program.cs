int num=int.Parse(Console.ReadLine());

for(int i=0;i<num;i++){
    string s=Console.ReadLine();
    string s1="";
       string s2="";

    if(s.Length%2==0){
       int m= s.Length/2;

       for(int k=0;k<m;k++){
        s1+=s[k];
       }

       for(int l=m;l<s.Length;l++){
        s2+=s[l];
       }
       //s2+=s[s.Length-1];
       if(s1==s2){
        Console.WriteLine("YES");
       }
       else if(s1!=s2){
        Console.WriteLine("NO");
       }
    }

    else{
        Console.WriteLine("NO");
    }

    
}