using System.Text;

string location = "Dhaka";

location += " , Bangladesh";

StringBuilder stringBuilder = new StringBuilder(location);

Console.WriteLine(stringBuilder);

stringBuilder.Replace('l', 'q');
stringBuilder.Insert(17, '.');


Console.WriteLine(stringBuilder);