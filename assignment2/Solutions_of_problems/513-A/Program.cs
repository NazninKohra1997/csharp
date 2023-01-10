int[] arr=new int[4];
string st="";
for(int i=0;i<1;i++){
    var num=new string[1];
    num=Console.ReadLine().Split();
    for(int j=0;j<4;j++){
         string s=num[j].ToString();
         arr[j]=int.Parse(s);
    }
}

for(int i=0;i<arr.Length;i++){
   // Console.WriteLine(arr[i]);
}

//Console.WriteLine(st);

int a=arr[0];
int b=arr[1];
int c=arr[2];
int d=arr[3];






if(a>b){
    Console.WriteLine("First");
}
else if(b>a){
    Console.WriteLine("Second");
}
 else if(a==b && a!=49 && b!=49 && c>d){
  Console.WriteLine("First");
}
 else if(a==b && d>c){
    Console.WriteLine("Second");
}

 else {
    Console.WriteLine("Second");
} 