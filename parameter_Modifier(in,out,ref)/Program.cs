int point1(in int number){
    return number;
}

int point2(out int value){
    value=32;
    return value;
}

int point3(ref int value1){
    value1=3;
    return value1;
}


Console.WriteLine(point1(5));
int f=5;
int a=point2(out f);
Console.WriteLine(a);

int j=44;
int b=point3(ref j);
Console.WriteLine(b);
