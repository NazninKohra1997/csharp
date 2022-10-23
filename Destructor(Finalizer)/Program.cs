using oop;

public class program{
    public static void Main(string[] args){
        animal Cat= new animal("white");
        Cat.CatNumber=20;

        Console.WriteLine(Cat.Animal);
        Console.WriteLine(Cat.CatNumber);
    }
}