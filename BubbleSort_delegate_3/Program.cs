using Delegate;

Sorting<double> s=new Sorting<double>();

List<double> ls=new List<double>{3.4,2.1,6.7,0.9,20,22.2};

var sorted=s.BubbleSort(ls, Sort);


int Sort(double x, double y){
    if(x==y){
        return 0;
    }
    else if(x>y){
        return 1;
    }
    else{
        return -1;
    }

}

foreach(var i in ls){
    Console.WriteLine(i);
}