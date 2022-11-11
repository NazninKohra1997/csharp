using oop;
public class Hovercraft:ICar,IAeroplane{
       public void StartEngine(){
        Console.WriteLine("From Car");
       }

       public void StopEngine(){
        Console.WriteLine("From Aeropane");
       }
}