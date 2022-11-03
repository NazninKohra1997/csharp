using oop;
public class Rectangle:shape{
    public double height{get; private set;}
    public double width{get; private set;}

    public Rectangle(double Height, double Width,string name):base(name){
              height=Height;
              width=Width;
    }

    public override double  CalculateArea(){
        return height*width;
    }
}