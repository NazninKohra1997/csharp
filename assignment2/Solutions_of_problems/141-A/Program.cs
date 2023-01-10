string s1=Console.ReadLine();
string s2=Console.ReadLine();
string s3=Console.ReadLine();

int l3=s3.Length;
int[] arr3=new int[l3];

/*for(int i=0;i<s1.Length;i++){
    arr1[i]=s1[i]+'0';
}

for(int i=0;i<arr1.Length;i++){
    for(int j=i+1;j<arr1.Length;j++){
        if(arr1[i]>arr1[j]){
            int temp=arr1[i];
            arr1[i]=arr1[j];
            arr1[j]=temp;
        }
    }
}

string ss1="";
for(int i=0;i<arr1.Length;i++){
    string q1=arr1[i].ToString();
    //Console.WriteLine(q1);
    ss1+=q1;
}

//Console.WriteLine(ss1);

for(int i=0;i<s2.Length;i++){
    arr2[i]=s2[i]+'0';
}

for(int i=0;i<arr2.Length;i++){
    for(int j=i+1;j<arr2.Length;j++){
        if(arr2[i]>arr2[j]){
            int temp=arr2[i];
            arr2[i]=arr2[j];
            arr2[j]=temp;
        }
    }
}

string ss2="";

for(int i=0;i<arr2.Length;i++){
    //Console.WriteLine(arr2[i]);
    string q2=arr2[i].ToString();
    ss2+=q2;
}*/

//Console.WriteLine(ss2);

for(int i=0;i<s3.Length;i++){
    arr3[i]=s3[i]+'0';
}

for(int i=0;i<arr3.Length;i++){
    for(int j=i+1;j<arr3.Length;j++){
        if(arr3[i]>arr3[j]){
            int temp=arr3[i];
            arr3[i]=arr3[j];
            arr3[j]=temp;
        }
    }
}


string ss3="";
for(int i=0;i<arr3.Length;i++){
    //Console.WriteLine(arr2[i]);
    string q3=arr3[i].ToString();
    ss3+=q3;
}


string f=s1+s2;
int len=f.Length;
int[] arr4=new int[len];

for(int i=0;i<f.Length;i++){
    arr4[i]=f[i]+'0';
}

for(int i=0;i<arr4.Length;i++){
    for(int j=i+1;j<arr4.Length;j++){
        if(arr4[i]>arr4[j]){
            int temp=arr4[i];
            arr4[i]=arr4[j];
            arr4[j]=temp;
        }
    }
}


string ss4="";

for(int i=0;i<arr4.Length;i++){
    //Console.WriteLine(arr2[i]);
    string q4=arr4[i].ToString();
    ss4+=q4;
}

//Console.WriteLine(ss4);
//Console.WriteLine(ss3);

if(ss3==ss4){
    Console.WriteLine("YES");
}
else{
    Console.WriteLine("NO");
}