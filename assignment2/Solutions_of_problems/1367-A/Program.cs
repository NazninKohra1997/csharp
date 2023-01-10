int num=int.Parse(Console.ReadLine());
string st;
string s="";



for(int i=0;i<num;i++){
 st=Console.ReadLine();
 for(int j=0;j<st.Length-1;j++){
 if(j==0){
    s+=st[j];
 }   
 else if(st[j]==st[j-1]){
    s+=st[j];
    j++;
 }
 
}

s+=st[st.Length-1];
Console.WriteLine(s);
s="";
}