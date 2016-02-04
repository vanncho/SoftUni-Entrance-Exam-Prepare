using System;
using System.Text;

class BitRoller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());

        string nInBinary = Convert.ToString(n, 2).PadLeft(19, '0');
        StringBuilder bin = new StringBuilder(nInBinary);
        char charAtFPos = bin[bin.Length - 1 - f];
        bin.Remove(bin.Length - 1 - f, 1);

        for (int i = 0; i < r; i++)
        {
            char right = bin[bin.Length - 1];

            bin.Remove(bin.Length - 1, 1);
            bin.Insert(0, right);
        }

        bin.Insert(bin.Length - f, charAtFPos);

        int res = Convert.ToInt32(bin.ToString(), 2);

        Console.WriteLine(res);
    }
}
