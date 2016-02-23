using System;

class Dumbbell
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int outerDots = n / 2 - 1;
        int asterisks = n / 2;

        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), new string('&', n / 2 + 1), new string('.', n));
        for (int i = 0; i < n - 2; i++)
        {
            if (i < (n - 2) / 2)
            {
                Console.Write(new string('.', outerDots));
                Console.Write("&");
                Console.Write(new string('*', asterisks));
                Console.Write("&");
                Console.Write(new string('.', n));
                Console.Write("&");
                Console.Write(new string('*', asterisks));
                Console.Write("&");
                Console.WriteLine(new string('.', outerDots));
                outerDots--;
                asterisks++;
            }
            if (i == (n - 2) / 2)
            {
                Console.Write(new string('.', outerDots));
                Console.Write("&");
                Console.Write(new string('*', asterisks));
                Console.Write("&");
                Console.Write(new string('=', n));
                Console.Write("&");
                Console.Write(new string('*', asterisks));
                Console.Write("&");
                Console.WriteLine(new string('.', outerDots));
                outerDots++;
                asterisks--;
            }
            if (i > (n - 2) / 2)
            {
                Console.Write(new string('.', outerDots));
                Console.Write("&");
                Console.Write(new string('*', asterisks));
                Console.Write("&");
                Console.Write(new string('.', n));
                Console.Write("&");
                Console.Write(new string('*', asterisks));
                Console.Write("&");
                Console.WriteLine(new string('.', outerDots));
                outerDots++;
                asterisks--;
            }
        }
        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), new string('&', n / 2 + 1), new string('.', n));
    }
}
