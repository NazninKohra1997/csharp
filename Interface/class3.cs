namespace InterfaceUse;

public class LAN : IUSBDevice{
    bool _connect=true;

    public bool connect(){
         return _connect;
    }

    public string GetData(){
        return "LAN Data";
    }
}