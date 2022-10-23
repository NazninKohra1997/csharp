namespace oop;
public class flower{
    private int roseTree;
    private int sunFlower;
    
    public void put(string lily){
        if(roseTree>10){
            Console.WriteLine("Lily is not needed");
        }
        else{
            Console.WriteLine("Lily is needed");
        }
    }

    public int Rose{
        get{
            return roseTree;
        }
        set{
            roseTree=value;
        }
    }

    public int Sun{
        get{
            return sunFlower;
        }
        set{
            sunFlower=value;
        }
    }
}