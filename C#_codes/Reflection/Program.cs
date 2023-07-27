using Reflection;
using System.Reflection;

InShopping inShopping = new InShopping("Jhora", 5000);

double price = inShopping.PriceAfterDiscount(10);

Console.WriteLine(price);

Console.WriteLine();



Type t = typeof(InShopping);

ConstructorInfo constructor = t.GetConstructor(new Type[]  {typeof(string), typeof(double) });

if(constructor != null)
{
    object o = constructor.Invoke(new object[] { "Jhora", 5000 });

    MethodInfo method = t.GetMethod("PriceAfterDiscount");

    if(method != null)
    {
      object result =  method.Invoke(o, new object[] { 10 });
        Console.WriteLine(result);
    }
}