using System;

class HouseWithAWindow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // roof of the house
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 2 * n - 1; j++)
            {
                if (i + j == n - 1 || i - j == -(n - 1))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }

        // connection between roof and base
        Console.WriteLine(new string('*', 2 * n - 1));

        // base of the house
        for (int i = 0; i < n / 4; i++)
        {
            Console.Write("*");
            Console.Write(new string('.', (2 * n - 1) - 2));
            Console.WriteLine("*");
        }
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write("*");
            Console.Write(new string('.', n / 2));
            Console.Write(new string('*', n - 3));
            Console.Write(new string('.', n / 2));
            Console.WriteLine("*");
        }
        for (int i = 0; i < n / 4; i++)
        {
            Console.Write("*");
            Console.Write(new string('.', (2 * n - 1) - 2));
            Console.WriteLine("*");
        }

        // house foundation
        Console.WriteLine(new string('*', 2 * n - 1));
    }
}
