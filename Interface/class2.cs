namespace InterfaceUse;

public class Laptop{
    IUSBDevice port1;
    IUSBDevice port2;

    public void AddDevicePort1(IUSBDevice device){
        port1=device;
    }

    public void AddDevicePort2(IUSBDevice device){
        port2=device;
    }

    public string GetDataFromPort1(){
        port1.connect();
        return port1.GetData();
    }

    public string GetDataFromPort2(){
        port2.connect();
        return port2.GetData();
    }
}