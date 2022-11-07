namespace InterfaceUse;

public class Keyboard : IUSBDevice{
    public bool connect(){
        return true;
    }

    public string GetData(){
        return "Data from Keyboard";
    }
}