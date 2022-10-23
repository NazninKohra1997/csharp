namespace oop;

public class bottle{
    private int amount;
    public string name;
public int waterAmount{
        get{
            return amount;
        }
        set{
            amount=value;
        }
    }

    public int addWater(int milk){
        amount+=milk;
        return amount;
    }

    public string addWater(string name1){
        name+=name1;
         return name;
    }
}