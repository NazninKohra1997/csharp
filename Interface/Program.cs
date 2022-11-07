using InterfaceUse;
public class program{
    public static void Main(string[] args){
        Laptop laptop=new Laptop();

        laptop.AddDevicePort1(new Keyboard());
        Console.WriteLine(laptop.GetDataFromPort1());
        
        laptop.AddDevicePort2(new LAN());
        Console.WriteLine(laptop.GetDataFromPort2());
    }
}