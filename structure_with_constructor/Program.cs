using oop;

Structure st1=new Structure();
Structure st2=new Structure();

st1.Item=20;

st2=st1;

st2.Item=33;

st1.price=37;

Console.WriteLine(st1.price);
Console.WriteLine(st1.Item);
Console.WriteLine(st2.Item);

Console.WriteLine();

Class cl1=new Class();
Class cl2=new Class();

cl1.age=22;
cl1=cl2;
cl2.age=33;
Console.WriteLine(cl1.age);
Console.WriteLine(cl2.age);