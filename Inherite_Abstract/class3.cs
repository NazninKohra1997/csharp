public class program{
    static void Main(string[] args){
        Circle cr= new Circle(2,"Circlelo");
        Rectangle rec=new Rectangle(4,5,"Rectanglelo");

        Console.WriteLine(cr.Name);
        Console.WriteLine(cr.CalculateArea());
        Console.WriteLine(cr.Color("Red"));

        Console.WriteLine();

        Console.WriteLine(rec.Name);
        Console.WriteLine(rec.CalculateArea());
        Console.WriteLine(rec.Color("blue"));

    }
}