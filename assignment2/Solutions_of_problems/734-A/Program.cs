int num=int.Parse(Console.ReadLine());

string ch=Console.ReadLine(); 

int a=0;
int d=0;

for(int i=0;i<ch.Length;i++){
     if (ch[i] == 'A'){
                a = a + 1;
     }
            else{
                d = d + 1;
            }
}


if (a > d){
     Console.WriteLine("Anton");
}

 else if (d > a){
    Console.WriteLine("Danik");
 }

 else{
    Console.WriteLine("Friendship");
 }