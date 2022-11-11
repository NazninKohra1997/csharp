namespace oop;

public struct Structure{
    private int item;
    public int price;

    public Structure(int item){
        this.item=item;
        price=10;
    }

    public int Item{
        get{
            return item;
        }
        set{
            item=value;
        }
    }

}