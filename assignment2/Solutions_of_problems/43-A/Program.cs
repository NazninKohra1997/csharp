int n=int.Parse(Console.ReadLine());
string team="";
string win="";
int goal=0;

for(int i=0;i<n;i++){
     if (goal != 0)
        {
             team=Console.ReadLine();
            if (team == win)
            {
                goal += 1;
            }
            else
            {
                goal -= 1;
            }
        }
        else
        {
            win=Console.ReadLine();
            goal = 1;
        }

}

Console.WriteLine(win);