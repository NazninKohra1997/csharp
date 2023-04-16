using System.Collections;

BitArray arr = new BitArray(5);
Printvalue(arr, 8);

static void Printvalue(IEnumerable myList, int myWidth)
{
    int i = myWidth;

    foreach(object obj in myList)
    {
        if (i <= 0)
        {
            i = myWidth;
            Console.WriteLine();
        }
        i--;
        Console.Write("{0,8}",obj);
    }
    Console.WriteLine();
}