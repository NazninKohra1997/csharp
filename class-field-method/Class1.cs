namespace oop;

class WaterBottle{
    public double waterAmount;    //field
    internal int water;

    public void AddWater(double amount){   //method
            waterAmount+=amount;
            Console.WriteLine(waterAmount);
    }
}