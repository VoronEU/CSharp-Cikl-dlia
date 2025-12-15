using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        for (int i = a; i <= b; i++)
        {
            int n = i;
            int sum = 0;

            while (n > 0)
            {
                int d = n % 10;
                sum += d * d * d;
                n /= 10;
            }

            if (sum == i)
                Console.WriteLine(i);
        }
    }
}
