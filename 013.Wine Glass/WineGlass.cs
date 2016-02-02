using System;

class WineGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(@"\{0}/", new string('*', n - 2));
        for (int i = 1; i <= n / 2 - 1; i++)
        {
            Console.Write(new string('.', i));
            Console.Write(@"\");
            Console.Write(new string('*', (n - 2) - (2 * i)));
            Console.Write("/");
            Console.Write(new string('.', i));
            Console.WriteLine();
        }
        if (n < 12)
        {
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.Write(new string('.', (n / 2) - 1));
                Console.Write("||");
                Console.Write(new string('.', (n / 2) - 1));
                Console.WriteLine();
            }

            Console.WriteLine(new string('-', n));
        }
        if (n >= 12)
        {
            for (int i = 0; i < n / 2 - 2; i++)
            {
                Console.Write(new string('.', (n / 2) - 1));
                Console.Write("||");
                Console.Write(new string('.', (n / 2) - 1));
                Console.WriteLine();
            }
            Console.WriteLine(new string('-', n));
            Console.WriteLine(new string('-', n));
        }

    }
}
