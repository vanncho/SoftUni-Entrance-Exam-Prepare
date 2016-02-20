using System;

class RockLq
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // top
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));

        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                if (2 * i + j == n - 2 || 2 * i - j == - (n + (n + 1)))
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

        // middle
        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                if ((2 * i + j == n - 1 || 2 * i - j == -2 * n) ||
                    (j == 0 || j == (3 * n) - 1) ||
                    (j == n - 1 || j == 2 * n))
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

        // end
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                if (i + j == n - 1 || i - j == - 2 * n)
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
        Console.WriteLine(new string('*', 3 * n));
    }
}
