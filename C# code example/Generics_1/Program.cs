using Generics_1;

Coordinate<int> coordinate = new Coordinate<int>();

coordinate.X = 10;
coordinate.Y = 20;

Coordinate<string> coordinate2 = new Coordinate<string>();

coordinate2.X = "East";
coordinate2.Y = "West";

Console.WriteLine(coordinate2.Y);