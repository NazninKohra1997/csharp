int a=0;
string st="";
int s=0;

for(int i=0;i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<2;j++){
        if(j==0){
            st=num[j];
        }
        else{
            a=int.Parse(num[j]);
        }
    }
}


for(int i=0;i<a;i++){
if(st[st.Length-1]!='0'){
    s=int.Parse(st);
    s=s-1;
    st=s.ToString();
    //Console.WriteLine(st);
}
else if(st[st.Length-1]=='0'){
     s=int.Parse(st);
    s=s/10;
    st=s.ToString();
    //Console.WriteLine(st);
}
}

Console.WriteLine(s);