using oop;

public class program{
    public static void Main(string[] args){
        flower flowername =new flower();

        flowername.Rose=int.Parse(Console.ReadLine());
        flowername.Sun=10;

        flowername.put("Lily");

        Console.WriteLine(flowername.Rose);
        Console.WriteLine(flowername.Sun);

    }
}