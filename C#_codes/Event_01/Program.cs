using Event_01;

Printer printer = new Printer();
printer.something += (a) => Console.WriteLine(a);    //annonymous method


printer.Printed();