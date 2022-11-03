using oop;
public class Circle:shape{
    public double radius{get; private set;}

    public Circle(double Radius,string name):base(name){
        radius=Radius;
    }

    public override double CalculateArea()
    {
        return Math.PI*radius*radius;
    }
}