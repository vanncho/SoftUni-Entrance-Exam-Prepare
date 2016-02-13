using System;

class PandaScotlandFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char letter = 'A';

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('~', i));
            Console.Write(letter);
            letter++;
            if (letter == '[')
            {
                letter = 'A';
            }
            Console.Write(new string('#', (n - 2) - (i * 2)));
            Console.Write(letter);
            letter++;
            if (letter == '[')
            {
                letter = 'A';
            }
            Console.Write(new string('~', i));
            Console.WriteLine();
        }

        Console.WriteLine("{0}{1}{0}", new string('-', n / 2), letter);
        letter++;
        if (letter == '[')
        {
            letter = 'A';
        }

        for (int i = (n / 2) - 1; i >= 0; i--)
        {
            Console.Write(new string('~', i));
            Console.Write(letter);
            letter++;
            if (letter == '[')
            {
                letter = 'A';
            }
            Console.Write(new string('#', (n - 2) - (i * 2)));
            Console.Write(letter);
            letter++;
            if (letter == '[')
            {
                letter = 'A';
            }
            Console.Write(new string('~', i));
            Console.WriteLine();
        }
    }
}
