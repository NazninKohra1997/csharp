int number = int.Parse(Console.ReadLine());

var arr = new int[number, number];


for(int i=0;i<number; i++)
{
    var num = new string[number];
    num = Console.ReadLine().Split();
    for(int j = 0; j < number; j++)
    {
        arr[i,j] = int.Parse(num[j]);
    }
}


