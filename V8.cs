using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] a = new double[n + 1];

        for (int i = 0; i <= n; i++)
            a[i] = double.Parse(Console.ReadLine());

        double x = double.Parse(Console.ReadLine());

        double result = a[0];
        for (int i = 1; i <= n; i++)
            result = result * x + a[i];

        Console.WriteLine(result);
    }
}
