using System;

class MagicWand
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        // top
        Console.WriteLine("{0}*{0}", new string('.', (3 * n + 2) / 2));
        int ouside = ((3 * n + 2) / 2) - 1;
        int inside = 1;
        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.Write(new string('.', ouside));
            Console.Write("*");
            Console.Write(new string('.', inside));
            Console.Write("*");
            Console.WriteLine(new string('.', ouside));
            ouside--;
            inside += 2;
        }

        // middle - top
        Console.WriteLine("{0}{1}{0}", new string('*', n), new string('.', (3 * n + 2) - 2 * n));
        int outerDots = 1;
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', outerDots));
            Console.Write("*");
            Console.Write(new string('.', (3 * n + 2) - (2 + (outerDots * 2))));
            Console.Write("*");
            Console.WriteLine(new string('.', outerDots));
            outerDots++;
        }
        // middle - bottom
        outerDots -= 2;
        int innerDots = 0;
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', outerDots));
            Console.Write("*");
            Console.Write(new string('.', n / 2));
            Console.Write("*");
            Console.Write(new string('.', innerDots));
            Console.Write("*");
            Console.Write(new string('.', n));
            Console.Write("*");
            Console.Write(new string('.', innerDots));
            Console.Write("*");
            Console.Write(new string('.', n / 2));
            Console.Write("*");
            Console.WriteLine(new string('.', outerDots));
            outerDots--;
            innerDots++;
        }
        Console.WriteLine("{0}{1}*{2}*{1}{0}", new string('*', n / 2 + 1), new string('.', n / 2), new string('.', n));

        // bottom
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', n));
            Console.Write("*");
            Console.Write(new string('.', n));
            Console.Write("*");
            Console.WriteLine(new string('.', n));
        }
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n + 2));
    }
}
