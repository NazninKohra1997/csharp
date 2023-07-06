using OOP_Polymorphism;

Class1 class1 = new Class1();
class1.Number = 56;
class1.FunctionOverride();
Console.WriteLine();

Class2 class2 = new Class2();
class2.Id = 99;
class2.FunctionOverride();  
Console.WriteLine();

Class3 class3 = new Class3();
class3.FunctionOverloading(44);
class3.FunctionOverloading("This is a function");