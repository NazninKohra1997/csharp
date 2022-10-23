namespace oop;

public class flowerContainer{
    private string color;
    private int capacity;

   public flowerContainer(string color,int capacity){
        this.color=color;
        this.capacity=capacity;
    }

    public string Color{
        get{
            return color;
        }
    }

    public int Capacity{
        get{
           if(capacity<0){
                return 0;
            }
            else{
                return capacity;
            }
        }
    }
}