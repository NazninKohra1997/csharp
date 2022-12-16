using System.IO;

var path="Test";

Directory.CreateDirectory(path);

string currentDirectory=Directory.GetCurrentDirectory();
Console.WriteLine(currentDirectory);


DirectoryInfo dir=new DirectoryInfo(currentDirectory);

foreach(var arr in currentDirectory){
     Console.Write(arr);
      
}