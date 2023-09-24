using p_21;

WaterBottle waterBottle = new WaterBottle(2, "Pran", 50);


double total1 = waterBottle.WaterAmount(50);
double total2  = waterBottle.WaterAmount(25.5);

double totalWater = total1 + total2;

waterBottle.GetInfo();
Console.Write("Total water amount of the bottle is ");
Console.Write(totalWater);
Console.WriteLine(" ml");