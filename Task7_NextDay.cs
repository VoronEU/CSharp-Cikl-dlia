using System;

class Program
{
    static bool IsLeap(int y)
    {
        return y % 400 == 0 || (y % 4 == 0 && y % 100 != 0);
    }

    static int DaysInMonth(int m, int y)
    {
        switch (m)
        {
            case 1: case 3: case 5: case 7:
            case 8: case 10: case 12: return 31;
            case 4: case 6: case 9: case 11: return 30;
            case 2: return IsLeap(y) ? 29 : 28;
            default: return 0;
        }
    }

    static void Main()
    {
        int d = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        d++;
        if (d > DaysInMonth(m, y))
        {
            d = 1;
            m++;
            if (m > 12)
            {
                m = 1;
                y++;
            }
        }

        Console.WriteLine($"{d} {m} {y}");
    }
}
