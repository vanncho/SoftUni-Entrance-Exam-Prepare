using System;

class Car
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char dot = '.';
        char asterisk = '*';

        // top
        Console.WriteLine("{0}{1}{0}", new string(dot, n), new string(asterisk, n));

        // windows
        for (int i = 0; i < ((n / 2) + 1) - 2; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                if (i + j == n - 1 || i - j == -(2 * n))
                {
                    Console.Write(asterisk);
                }
                else
                {
                    Console.Write(dot);
                }
            }
            Console.WriteLine();
        }

        // coupe
        Console.WriteLine("{0}{1}{0}", new string(asterisk, (n + 2) / 2), new string(dot, 3 * n - (2 * ((n + 2) / 2))));
        for (int i = 0; i < (n / 2) - 1; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                if (j == 0 || j == 3 * n - 1 || i == (n / 2) - 2)
                {
                    Console.Write(asterisk);
                }
                else
                {
                    Console.Write(dot);
                }
            }
            Console.WriteLine();
        }

        // tyres
        for (int i = 0; i < n / 2 - 2; i++)
        {
            Console.Write(new string(dot, n / 2));
            Console.Write(asterisk);
            Console.Write(new string(dot, n / 2 - 1));
            Console.Write(asterisk);
            Console.Write(new string(dot, n - 2));
            Console.Write(asterisk);
            Console.Write(new string(dot, n / 2 - 1));
            Console.Write(asterisk);
            Console.WriteLine(new string(dot, n / 2));
        }
        Console.WriteLine("{0}{1}{2}{1}{0}", new string(dot, n / 2), new string(asterisk, 2 + (n / 2 - 1)), new string(dot, n - 2));
    }
}
