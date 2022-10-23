namespace oop;

public class animal{
    private string color;
    private int numberOfcat;

    public animal(string color){
        this.color=color;
    }

    public string Animal{
        get{
            return color;
        }
    }

    public int CatNumber{
        get{
            return numberOfcat;
        }
        set{
            numberOfcat=value;
        }
    }

    ~animal(){
        color=null;
        numberOfcat=0;
    }
}