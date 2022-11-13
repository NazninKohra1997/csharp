using System.Text;
string location="Dhaka";

StringBuilder stringBuilder=new StringBuilder(location);
stringBuilder.Append(",Bangladesh");
stringBuilder.Replace('B','a');
stringBuilder.Insert(3,'.');

Console.WriteLine(stringBuilder);

stringBuilder[0]='B';
Console.WriteLine(stringBuilder);
