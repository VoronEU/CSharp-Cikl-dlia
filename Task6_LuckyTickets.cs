using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i <= 999999; i++)
        {
            int n = i;
            int s1 = 0, s2 = 0;

            for (int j = 0; j < 3; j++)
            {
                s2 += n % 10;
                n /= 10;
            }
            for (int j = 0; j < 3; j++)
            {
                s1 += n % 10;
                n /= 10;
            }

            if (s1 == s2)
                Console.WriteLine(i.ToString("D6"));
        }
    }
}
