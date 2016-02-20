using System;

class ConsoleGraphics
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // bridge top
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(new string('*', 2 * n));
        }

        // bridge foundations
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('*', (n / 2) + 1), new string(' ', (2 * n) - 2 * ((n / 2) + 1)));
        }

        // water
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(new string('~', 2 * n));
        }
    }
}
