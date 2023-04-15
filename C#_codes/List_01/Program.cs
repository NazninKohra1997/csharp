List<int> list = new List<int>();

list.Add(1);
list.Add(12);
list.Add(44);
list.Add(50);

foreach(var i in list)
{
    Console.WriteLine(i);
}

Console.WriteLine();

List<string> list1 = new List<string>();

list1.Add("Dhaka");
list1.Add("Sylhet");
list1.Add("Khulna");

list1.Remove("Khulna");

foreach(var i in list1)
{
    Console.WriteLine(i);
}

Console.WriteLine();

for (int i = 0; i < list1.Count; i++)
{
    Console.WriteLine(list1[i]);
}