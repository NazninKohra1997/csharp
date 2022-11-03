namespace oop;
public abstract class shape{
    public string Name{get; private set;}
    public string color{get; set;}

    public shape(string name){
        Name=name;
    }

    public string Color(string colour){
        color=colour;
        return color;
    }

public abstract double CalculateArea();
}