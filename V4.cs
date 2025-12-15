using System;

class Program
{
    static int SumDivisors(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n / 2; i++)
            if (n % i == 0)
                sum += i;
        return sum;
    }

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        for (int i = a; i <= b; i++)
        {
            int j = SumDivisors(i);
            if (j > i && j <= b && SumDivisors(j) == i)
                Console.WriteLine($"{i} {j}");
        }
    }
}
