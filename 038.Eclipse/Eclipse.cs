using System;

class Eclipse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // top
        Console.Write(" ");
        Console.Write(new string('*', (n * 2) - 2));
        Console.Write(" ");
        Console.Write(new string(' ', n - 1));
        Console.Write(" ");
        Console.Write(new string('*', (n * 2) - 2));
        Console.WriteLine(" ");

        for (int i = 0; i < n - 2; i++)
        {
            Console.Write('*');
            Console.Write(new string('/', (n * 2) - 2));
            Console.Write('*');
            if (i == (n / 2) - 1)
            {
                Console.Write(new string('-', n - 1));
            }
            else
            {
                Console.Write(new string(' ', n - 1));
            }
            Console.Write('*');
            Console.Write(new string('/', (n * 2) - 2));
            Console.WriteLine('*');
        }

        // bottom
        Console.Write(" ");
        Console.Write(new string('*', (n * 2) - 2));
        Console.Write(" ");
        Console.Write(new string(' ', n - 1));
        Console.Write(" ");
        Console.Write(new string('*', (n * 2) - 2));
        Console.WriteLine(" ");
    }
}
