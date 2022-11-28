namespace InterfaceExample{
    public class Square:ICalculate{
            public int Height{get; private set;}
            public int Width{get; private set;}

            public Square(int Height,int Width){
                this.Height=Height;
                this.Width=Width;
            }

            public double CalculateArea(){
                return Height*Width;
            }
    }
}