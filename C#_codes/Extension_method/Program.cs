using Extension_method;


List<int> list1 = new List<int>() { 34, 65, 25, 111, 76, 90 };

var result = list1.Even();

foreach(var items in result)
{
    Console.WriteLine(items);
}