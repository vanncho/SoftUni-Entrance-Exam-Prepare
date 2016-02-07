using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // top
        Console.Write(new string('*', n * 2));
        Console.Write(new string(' ', n));
        Console.WriteLine(new string('*', n * 2));

        for (int i = 0; i < n - 2; i++)
        {
            Console.Write('*');
            Console.Write(new string('/', (n * 2) - 2));
            Console.Write('*');
            if (i == (n / 2) - 1)
            {
                Console.Write(new string('|', n));
            }
            else
            {
                Console.Write(new string(' ', n));
            }
            Console.Write('*');
            Console.Write(new string('/', (n * 2) - 2));
            Console.WriteLine('*');
        }

        // bottom
        Console.Write(new string('*', n * 2));
        Console.Write(new string(' ', n));
        Console.WriteLine(new string('*', n * 2));
    }
}
