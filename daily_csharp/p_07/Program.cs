int[][][] roll = new int[2][][];

roll[0] = new int[2][];
roll[1] = new int[1][];



roll[0][0] = new int[2];
roll[0][1] = new int[1];

roll[1][0] = new int[1];




roll[0][0][0] = 101;
roll[0][0][1] = 102;

roll[0][1][0] = 103;


roll[1][0][0] = 202;




Console.WriteLine(roll[1][0][0]);