using Delegate;

Do d=new Do();
d.Item1=2;
d.Item2=3;

d.Done(Sum);


int Sum(int a,int b){
    return a+b;
}
