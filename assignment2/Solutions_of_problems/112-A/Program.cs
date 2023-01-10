int fun(char s){
   int sum=0;
    if(s=='a' || s=='A'){
         sum=1;
    }
    else if(s=='b' || s=='B'){
        sum=2;
    }
    else if(s=='c' || s=='C'){
        sum=3;
    }
    else if(s=='d' || s=='D'){
        sum=4;
    }
    else if(s=='e' || s=='E'){
        sum=5;
    }
    else if(s=='f' || s=='F'){
        sum=6;
    }
     else if(s=='g' || s=='G'){
        sum=7;
    }
     else if(s=='h' || s=='H'){
        sum=8;
    }
     else if(s=='i' || s=='I'){
        sum=9;
    }
     else if(s=='j' || s=='J'){
        sum=10;
    }
     else if(s=='k' || s=='K'){
        sum=11;
    }
     else if(s=='l' || s=='L'){
        sum=12;
    }
     else if(s=='m' || s=='M'){
        sum=13;
    }
     else if(s=='n' || s=='N'){
        sum=14;
    }
     else if(s=='o' || s=='O'){
        sum=15;
    }
     else if(s=='p' || s=='P'){
        sum=16;
    }
     else if(s=='q' || s=='Q'){
        sum=17;
    }
     else if(s=='r' || s=='R'){
        sum=18;
    }
     else if(s=='s' || s=='S'){
        sum=19;
    }
     else if(s=='t' || s=='T'){
        sum=20;
    }
     else if(s=='u' || s=='U'){
        sum=21;
    }
     else if(s=='v' || s=='V'){
        sum=22;
    }
     else if(s=='w' || s=='W'){
        sum=23;
    }
     else if(s=='x' || s=='X'){
        sum=24;
    }
     else if(s=='y' || s=='Y'){
        sum=25;
    }
     else if(s=='z' || s=='Z'){
        sum=26;
    }

    return sum;

}

string s1=Console.ReadLine();
string s2=Console.ReadLine();

int sum1;
int sum2;



int ss=0;



for(int i=0;i<s1.Length;i++){
    sum1=fun(s1[i]);
    sum2=fun(s2[i]);

    if(sum1>sum2){
       // Console.WriteLine("1");
       ss=1;
        break;
    }
    else if(sum1<sum2){
        //Console.WriteLine("-1");
        ss=-1;
        break;
    }
   
}

Console.WriteLine(ss);