using Event;

Fire f = new Fire();

f.OverHeat+=fun;
f.Firing(10);


void fun(int heat){
    Console.WriteLine($"Heat is {heat}");
}