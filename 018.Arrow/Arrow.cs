using System;

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('#', n));
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(new string('.', n / 2));
            Console.Write("#");
            Console.Write(new string('.', n - 2));
            Console.Write("#");
            Console.WriteLine(new string('.', n / 2));
        }
        Console.WriteLine("{1}{0}{1}", new string('.', n - 2), new string('#', (n / 2) + 1));
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < (2 * n) - 1; j++)
            {
                if (i + j == (n * 2) - 3 || i - j == -1)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}
