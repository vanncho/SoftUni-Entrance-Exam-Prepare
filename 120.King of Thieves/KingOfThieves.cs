using System;

class KingOfThieves
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char type = char.Parse(Console.ReadLine());

        int dashes = n / 2;
        int typeCount = 1;

        for (int i = 0; i < n; i++)
        {
            if (i < n / 2)
            {
                Console.Write(new string('-', dashes));
                Console.Write(new string(type, typeCount));
                Console.WriteLine(new string('-', dashes));
                dashes--;
                typeCount += 2;
            }
            if (i == n / 2)
            {
                Console.WriteLine(new string(type, n));
                dashes = 1;
                typeCount -= 2;
            }
            if (i > n / 2)
            {
                Console.Write(new string('-', dashes));
                Console.Write(new string(type, typeCount));
                Console.WriteLine(new string('-', dashes));
                dashes++;
                typeCount -= 2;
            }
        }
    }
}
