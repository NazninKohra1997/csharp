double Getvalue(params double[] arr){
    var sum=0.0;
    foreach(var ars in arr){
        sum+=ars;
    }

    return sum;
}

double d= Getvalue(1.1,2.2,3.4,5,6);
Console.WriteLine(d);