using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n == 1 || n == 2)
        {
            Console.WriteLine(1);
            return;
        }

        long a = 1, b = 1;

        for (int i = 3; i <= n; i++)
        {
            long c = a + b;
            a = b;
            b = c;
        }

        Console.WriteLine(b);
    }
}
