namespace VirtualExample{
    public class Circle:Square{
        public Circle(int Height,int Width):base(Height,Width){

        }

        public override double CalculteArea(){
            return Math.PI*Height*Height;
        }
    }
}