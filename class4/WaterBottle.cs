namespace WaterExample{
    public class WaterBottle{
        public string Color{get; private set;}

        public int Amount{get; private set;}

        public WaterBottle(string Color,int Amount){
            this.Color=Color;
            this.Amount=Amount;
        }
    }
}