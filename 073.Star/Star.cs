using System;

class Star
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // top
        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 0; j < (2*n+1); j++)
            {
                if (i + j == n || i - j == -n)
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
        Console.WriteLine("{0}{1}{0}", new string('*', (n + 2) / 2), new string('.', (2 * n + 1) - 2 * ((n + 2) / 2)));
        for (int i = 0; i < n / 2 - 1; i++)
        {
            for (int j = 0; j < (2*n+1); j++)
            {
                if (i + j == n * 2 - 1 || i - j == -1)
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

        // between middle and bottom
        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 0; j < (2*n+1); j++)
            {
                if ((i + j == n / 2 || i - j == -(n + n / 2)) ||
                    (i + j == n || i - j == -n))
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

        // bottom
        Console.WriteLine("{0}{1}{0}", new string('*', (n + 2) / 2), new string('.', (2 * n + 1) - 2 * ((n + 2) / 2)));
    }
}
