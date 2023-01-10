//void swap(int a, int b){
  //  int temp=a;
    //a=b;
    //b=temp;
//}

string st=Console.ReadLine();
int length=st.Length;
//onsole.WriteLine(length);

for(int i=0;i<st.Length;i++){
  //  Console.WriteLine(st[i]);
    if(st[i]=='+'){
        length=length-1;
       // Console.WriteLine(length);
    }
}

int[] arr=new int[length];

//Console.WriteLine(length);
string ss="";

for(int i=0;i<st.Length;i++){
    if(st[i]!='+'){
        ss=ss+st[i];
    }
}



for(int i=0;i<ss.Length;i++){
    int a=ss[i]-'0';
    arr[i]=a;
   // Console.WriteLine(a);
}

//Console.WriteLine(arr.Length);

for(int i=0;i<arr.Length;i++){
    for(int j=i+1;j<arr.Length;j++){
         if(arr[i]>arr[j]){
           int temp=arr[i];
           arr[i]=arr[j];
           arr[j]=temp;
         }
    }
    //Console.WriteLine(arr[i]);

}

string s1="";
for(int i=0;i<arr.Length-1;i++){
   //int val=arr[i];
   string s=arr[i].ToString();
   s1+=s;
   s1+='+';
  
}

s1+=arr[arr.Length-1];

Console.WriteLine(s1);