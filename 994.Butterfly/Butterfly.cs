namespace _994.Butterfly
{
    using System;
    using System.Collections.Generic;

    public class Butterfly
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // top
            for (int i = 0; i < n - 2; i++)
            {
                char symbol = new char();

                if (i % 2 == 0)
                {
                    symbol = '*';
                }
                else
                {
                    symbol = '-';
                }

                Console.WriteLine("{0}\\ /{0}", new string(symbol, n - 2));
            }

            // middle
            Console.WriteLine("{0}@{0}", new string(' ', n - 1));

            // bottom
            for (int i = 0; i < n - 2; i++)
            {
                char symbol = new char();

                if (i % 2 == 0)
                {
                    symbol = '*';
                }
                else
                {
                    symbol = '-';
                }

                Console.WriteLine("{0}/ \\{0}", new string(symbol, n - 2));
            }
        }
    }
}
