using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        double result = 1;
        for (int i = 0; i < Math.Abs(n); i++)
            result *= x;

        if (n < 0)
            result = 1 / result;

        Console.WriteLine(result);
    }
}
