using oop;
public class program{
    public static void Main(string[] args){
        bottle bottle1=new bottle();
        bottle1.Number=20;
        bottle1.IsOpen=true;

        Console.WriteLine(bottle1.Number);
        Console.WriteLine(bottle1.IsOpen);
    }
}