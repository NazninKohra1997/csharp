namespace oop;

public class animal{
    private string color;
    private int numberOfcat;

    public animal(string color){
        this.color=color;
    }

     ~animal(){
        color=null;
        numberOfcat=0;
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

}