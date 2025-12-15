using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int even = 0;
        if (a % 2 == 0) even++;
        if (b % 2 == 0) even++;
        if (c % 2 == 0) even++;

        Console.WriteLine(even == 1 ? "истина" : "ложь");
    }
}
