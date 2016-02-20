using System;

class Diamonds
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i + j == n / 2 || i - j == - (n / 2) ||
                    (i + j == n + (n / 2) - 1 || i - j == n / 2))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine();
        }
    }
}
