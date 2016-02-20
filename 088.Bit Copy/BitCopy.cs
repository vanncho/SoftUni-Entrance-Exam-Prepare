using System;
using System.Text;

class BitCopy
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        string numberAsBits = Convert.ToString(n, 2).PadLeft(32, '0');
        char[] bits = numberAsBits.ToCharArray();

        int pos = 31 - p;
        char bitAtPos = bits[pos];
        bits[pos] = bitAtPos;
        bits[29] = bitAtPos;

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < bits.Length; i++)
        {
            result.Append(bits[i]);
        }

        long number = Convert.ToInt32(result.ToString(), 2);
        Console.WriteLine(number);
    }
}
