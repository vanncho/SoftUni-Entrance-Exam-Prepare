using System;

class Sunlight
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = 3 * n;
        Console.WriteLine("{0}*{0}", new string('.', (width - 1) / 2));

        // top
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (i + j == width - 2 || i - j == -1 || j == width / 2)
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

        // center
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
        }
        Console.WriteLine(new string('*', width));
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
        }

        // bottom
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (i + j == n - 1 || i - j == -(2 * n) || j == width / 2)
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

        Console.WriteLine("{0}*{0}", new string('.', (width - 1) / 2));
    }
}