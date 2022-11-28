namespace VirtualExample{
    public class Square{
        public int Height{get; private set;}
        public int Width{get; private set;}

        public Square(int Height,int Width){
            this.Height=Height;
            this.Width=Width;
        }

        public  virtual double CalculteArea(){
            return Height*Width;
        }
    }
}