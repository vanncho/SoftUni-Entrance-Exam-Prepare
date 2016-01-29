using System;

class IlluminatiLock
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', (n - 2) - (i * 2)));
            Console.Write(new string('#', 2));
            Console.Write(new string('.', i * 2));
            Console.Write('#');
            Console.Write(new string('.', n - 2));
            Console.Write('#');
            Console.Write(new string('.', i * 2));
            Console.Write(new string('#', 2));
            Console.Write(new string('.', (n - 2) - (i * 2)));
            Console.WriteLine();
        }

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', 1 + (i * 2)));
            Console.Write(new string('#', 2));
            Console.Write(new string('.', n - 3 - (i * 2)));
            Console.Write('#');
            Console.Write(new string('.', n - 2));
            Console.Write('#');
            Console.Write(new string('.', n - 3 - (i * 2)));
            Console.Write(new string('#', 2));
            Console.Write(new string('.', 1 + (i * 2)));
            Console.WriteLine();
        }

        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
    }
}
