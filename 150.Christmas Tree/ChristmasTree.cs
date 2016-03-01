using System;

class ChristmasTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char ch = '\'';

        Console.WriteLine("{0}^{0}", new string(ch, n));
        int snowsCount = n - 1;
        int leavesCount = 3;
        for (int i = 0; i < n / 2; i++)
        {
                Console.Write(new string(ch, snowsCount));
                Console.Write(new string('^', leavesCount));
                Console.WriteLine(new string(ch, snowsCount));
                leavesCount += 2;
                snowsCount -= 1;
        }
        snowsCount = n - 1;
        leavesCount = 3;
        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.Write(new string(ch, snowsCount));
            Console.Write(new string('^', leavesCount));
            Console.WriteLine(new string(ch, snowsCount));
            leavesCount += 2;
            snowsCount -= 1;
        }
        snowsCount = n - 1;
        leavesCount = 3;
        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.Write(new string(ch, snowsCount));
            Console.Write("| |");
            Console.WriteLine(new string(ch, snowsCount));
        }
        Console.WriteLine(new string('-', 2 * n + 1));
    }
}
