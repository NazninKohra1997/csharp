int num=int.Parse(Console.ReadLine());
string s=Console.ReadLine();

int sum=0;

for(int i=0;i<s.Length;i++){
        if(i==s.Length-1){
            break;
        }
        else{
            if(s[i]==s[i+1]){
                sum+=1;
            }
        }
}


Console.WriteLine(sum);