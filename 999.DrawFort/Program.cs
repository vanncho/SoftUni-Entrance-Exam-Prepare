namespace _999.DrawFort
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n;
            int row = n / 2; // row -> ^

            // top
            Console.WriteLine(@"/{0}\{1}/{0}\", new string('^', row), new string('_', width - ((2 * row) + 4)));

            // middle
            for (int i = 0; i < n - 3; i++)
            {
                for (int j = 0; j < 2 * n; j++)
                {
                    if (j == 0 || j == 2 * n - 1)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            // bottom
            Console.WriteLine("|{0}{1}{0}|", new string(' ', row + 1), new string('_', width - ((2 * row) + 4)));
            Console.WriteLine(@"\{0}/{1}\{0}/", new string('_', row), new string(' ', width - ((2 * row) + 4)));
        }
    }
}
