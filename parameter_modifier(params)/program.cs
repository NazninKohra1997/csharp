public class program{
    public static void Main(string[] args){
         
double d=CalculateAverage(new double[]{2,3,4});
double e=CalculateAverage(1,2,3,4,5);
Console.WriteLine(d);
Console.WriteLine(e);


double CalculateAverage(params double[] arr){
    double sum=0;
    foreach(var ar in arr){
        sum+=ar;
    }
        return sum/arr.Length;
}
    }
}