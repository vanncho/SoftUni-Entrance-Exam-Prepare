using System;

    class Summertime
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            // top
            Console.WriteLine("{0}{1}{0}", new string(' ', n / 2), new string('*', n + 1));
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.Write(new string(' ', n / 2));
                Console.Write("*");
                Console.Write(new string(' ', n - 1));
                Console.Write("*");
                Console.WriteLine(new string(' ', n / 2));
            }

            // neck of the bottle
            int spaceOutside = n / 2 - 1;
            int spaceInside = n + 1;
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string(' ', spaceOutside), new string(' ', spaceInside));
                spaceOutside--;
                spaceInside+=2;
            }

            // botle contains
            for (int i = 0; i < 2 * n; i++)
            {
                if (i < n)
                {
                    Console.WriteLine("*{0}*", new string('.', 2 * n - 2));
                }
                else if(i >= n)
                {
                    Console.WriteLine("*{0}*", new string('@', 2 * n - 2));
                }
            }

            // bottom
            Console.WriteLine(new string('*', 2 * n));
        }
    }
