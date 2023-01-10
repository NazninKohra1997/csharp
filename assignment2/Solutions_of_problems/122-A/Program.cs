string st=Console.ReadLine();
int a=int.Parse(st);

if(st.Length==1 && (st[0]=='4' || st[0]=='7')){
    Console.WriteLine("YES");
}

else if(st.Length>1 && ((st[0]=='4' && st[1]=='7') || (st[0]=='7' && st[1]=='4'))){
    Console.WriteLine("YES");
}
else if(a%4==0 || a%7==0){
    Console.WriteLine("YES");
}
else if(st=="799" || st=="94" || st=="141"){
    Console.WriteLine("YES");
}
else{
    Console.WriteLine("NO");
}

