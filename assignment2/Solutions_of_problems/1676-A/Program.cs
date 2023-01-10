int number=int.Parse(Console.ReadLine());
int sum1=0;
int sum2=0;

for(int i=0;i<number;i++){
    string st=Console.ReadLine();
    for(int j=0;j<3;j++){
        string s= st[j].ToString();
        sum1+= int.Parse(s);
    }
    for(int k=3;k<st.Length;k++){
        string t= st[k].ToString();
        sum2+= int.Parse(t);
    }

    if(sum1==sum2){
        Console.WriteLine("YES");
    }
    else{
        Console.WriteLine("NO");
    }

    sum1=0;
    sum2=0;

}