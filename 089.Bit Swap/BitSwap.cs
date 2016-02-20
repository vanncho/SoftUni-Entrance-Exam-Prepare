using System;
using System.Text;

class BitSwap
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        string nAsBits = Convert.ToString(n, 2).PadLeft(64, '0');

        char[] bits = nAsBits.ToCharArray();

        char swap = bits[60];
        bits[60] = bits[39];
        bits[39] = swap;

        StringBuilder res = new StringBuilder();

        for (int i = 0; i < bits.Length; i++)
        {
            res.Append(bits[i]);
        }

        long number = Convert.ToInt64(res.ToString(), 2);
        Console.WriteLine(number);
    }
}
