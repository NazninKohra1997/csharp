string Person(in string name){
    return name;
}

int Student(out int roll){
    roll=10;
    return roll;
}


double array(ref double[] arr){
    double sum=0.0;
    foreach(double ars in arr){
        sum+=ars;
    }
    return sum;
}


string n="Raisa";
string j=Person(n);
Console.WriteLine(j);

int t=10;
int k= Student(out t);
Console.WriteLine(t);

double[] arrrr= new double[] {1.1,2.2,3.0,2};
double l=array(ref arrrr);
Console.WriteLine(l);