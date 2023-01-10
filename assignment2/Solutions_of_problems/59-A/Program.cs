string st=Console.ReadLine();
string st1=st.ToUpper();
string st2=st.ToLower();

int sum_up=0;
int sum_low=0;


for(int i=0;i<st.Length;i++){
    if(st[i]==st1[i]){
        sum_up+=1;
    }
    else if(st[i]==st2[i]){
        sum_low+=1;
    }
}

if(sum_low>sum_up){
    Console.WriteLine(st.ToLower());
}
else if(sum_low<sum_up){
    Console.WriteLine(st.ToUpper());
}
else{
    Console.WriteLine(st.ToLower());
}