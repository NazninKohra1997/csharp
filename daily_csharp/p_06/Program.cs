int[][][] age = new int[2][][];

age[0] = new int[2][];
age[1] = new int[1][];



age[0][0] = new int[2];
age[0][1] = new int[1];

age[1][0] = new int[2];




age[0][0][0] = 20;

age[0][1][0] = 30;

age[1][0][0] = 40;
age[1][0][1] = 42;




Console.WriteLine(age[1][0][0]);
