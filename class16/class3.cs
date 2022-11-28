namespace InterfaceExample{
    public class Circle{
        public int Radious{get; private set;}

        public Circle(int Radious){
            this.Radious=Radious;
        }

        public double CalculateArea(){
            return Math.PI*Radious*Radious;
        }
    }
}