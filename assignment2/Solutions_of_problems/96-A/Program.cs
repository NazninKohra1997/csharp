string s=Console.ReadLine();


int sum = 1;
string a="NO";
    for (int i = 1; i < s.Length; ++i)
    {
        if (s[i] == s[i - 1])
        {
            sum += 1;
            if (sum == 7)
            {
               a="YES";
                
                
            }
        }
        else
        {
            sum = 1;
        }
    }

 Console.WriteLine(a);