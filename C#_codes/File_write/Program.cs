var path = "../../../Demo1.txt";

if(!File.Exists(path))
    File.Create(path);

var st = "Love from Bangladesh!";

File.WriteAllText(path, st);