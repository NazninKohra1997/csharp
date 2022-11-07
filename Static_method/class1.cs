namespace staticClass;

internal class Calculator{
     public static double CalculateAverage(double[] arr){
        double sum=0;
        foreach(double a in arr){
               sum+=a;
        }
        return sum/arr.Length;
     }

}