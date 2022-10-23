namespace oop;

public class pen{
    private string color;
    private int capacity;

    public pen(string color, int capacity){
           this.color=color;
           this.capacity=capacity;
    }

    public pen(): this("blue",200){  //call the previous constructor for this parameter

    }

    public string PenColor{
        get{
            return color; 
        }
    }

    public int  PenCap{
        get{
            return capacity;
        }
    }
}