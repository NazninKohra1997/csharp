using oop;

public class program{
    public static void Main(string[] args){
        pen pen1=new pen("red",20);
        Console.WriteLine(pen1.PenColor);
        Console.WriteLine(pen1.PenCap);

        pen pen2=new pen();
        Console.WriteLine(pen2.PenColor);
        Console.WriteLine(pen2.PenCap);
    }
}