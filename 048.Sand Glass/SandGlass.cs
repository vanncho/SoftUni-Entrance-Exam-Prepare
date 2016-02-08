using System;

class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('*', n));

        for (int i = 0; i < (n / 2) - 1; i++)
        {
            Console.Write(new string('.', i + 1));
            Console.Write(new  string('*', (n - 2) - (2 * i)));
            Console.WriteLine(new string('.', i + 1));
        }

        Console.Write(new string('.', (n - 1) / 2));
        Console.Write("*");
        Console.WriteLine(new string('.', (n - 1) / 2));

        for (int j = 0; j < (n / 2) - 1; j++)
	    {
            Console.Write(new string('.', ((n - 3) / 2) - j));
            Console.Write(new string('*', 3 + (2 * j)));
            Console.WriteLine(new string('.', ((n - 3) / 2) - j));
	    }

        Console.WriteLine(new string('*', n));
    }
}
