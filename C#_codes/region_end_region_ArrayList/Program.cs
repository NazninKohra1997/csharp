#region Non generic Collections

using System.Collections;

ArrayList arr = new ArrayList();

arr.Add("Dhaka");
arr.Add(37);
arr.Add(55.90);

foreach(object i in arr)
{
    Console.WriteLine(i);
}

#endregion