string s1=Console.ReadLine();

string s2="hello";

int count=0;
int sum=0;

for(int i=0;i<s1.Length;i++){
    if(s1[i]==s2[count]){
        sum+=1;
       // Console.WriteLine(s2[count]);
        count++;
        if(count==5){
            break;
        }
    }
}

if(sum==5){
    Console.WriteLine("YES");
}
else{
    Console.WriteLine("NO");
}