using System;

class Boat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // boat sail
        int leftDots = n - 1;
        int asterisks = 1;

        for (int i = 0; i <= n / 2; i++)
        {
            Console.Write(new string('.', leftDots));
            Console.Write(new string('*', asterisks));
            Console.WriteLine(new string('.', n));
            leftDots -= 2;
            asterisks += 2;
        }

        leftDots = 2;
        asterisks = n - 2;
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', leftDots));
            Console.Write(new string('*', asterisks));
            Console.WriteLine(new string('.', n));
            leftDots += 2;
            asterisks -= 2;
        }

        // body of the boat
        for (int i = 0; i < (n - 1) / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', (i * 2)/ 2), new string('*', (n * 2) - 2 * i));
        }
    }
}
