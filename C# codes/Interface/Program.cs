using Interface;

Laptop laptop = new Laptop();
string l = laptop.DeviceInfo();
Console.WriteLine(l);

Mobile mobile = new Mobile();
string m = mobile.DeviceInfo();
Console.WriteLine(m);