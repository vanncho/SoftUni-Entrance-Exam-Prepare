using System;
class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < (n / 2) + 1; i++)
        {
            Console.Write(new string('-', (n / 2) - i));
            Console.Write(new string('*', n - (2 *((n / 2) - i))));
            Console.WriteLine(new string('-', (n / 2) - i));
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write("|");
            Console.Write(new string('*', n - 2));
            Console.WriteLine("|");
        }
    }
}
