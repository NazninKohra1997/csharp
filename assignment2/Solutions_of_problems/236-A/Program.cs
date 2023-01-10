string st=Console.ReadLine();

st = String.Concat(st.OrderBy(ch => ch));
int sum=0;

for(int i=0;i<st.Length;i++){
    //Console.WriteLine(st[i]);
    if(st[i]!=st[i+1]){
        sum++;
    }
    if(i==st.Length-2){
        break;
    }
}

sum+=1;

if(sum%2==0){
    Console.WriteLine("CHAT WITH HER!");
}
else{
    Console.WriteLine("IGNORE HIM!");
}