using oop;

public class program{
    public static void Main(string[] args){
        WaterBottle bottle=new WaterBottle();    //accessing WaterBottle class from Class1 file
        //bottle.waterAmount;                  //This was private. So not accessable
       
        bottle.waterAmount=4;            //This is now public
         bottle.AddWater(5.6);          //public,, so accessable
         bottle.water=10;               //internal, so accessable
        
        Console.WriteLine();
        Console.WriteLine(bottle.waterAmount);
        Console.WriteLine(bottle.water);


        WaterBottle bottle2=new WaterBottle();
        bottle2.waterAmount=300;
        
        Console.WriteLine();
        Console.WriteLine(bottle2.waterAmount);
    }
}

