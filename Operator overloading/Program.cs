using oop;

public class program{
    public static void Main(string[] args){
        bottle bottle1=new bottle();
        bottle bottle2=new bottle();

        bottle1.waterAmount=10;
        Console.WriteLine(bottle1.waterAmount);

        bottle2.addWater(20);
        Console.WriteLine(bottle2.addWater(20));

        bottle2.name="Ti";
        //bottle2.addWater("ra");

       // Console.WriteLine(bottle2.name);
        Console.WriteLine(bottle2.addWater("ra"));
    }
}