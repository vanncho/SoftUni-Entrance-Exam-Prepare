using System;
using System.Text;

class ChangeEvenBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        ulong l = 0;
        int bitsChangeCount = 0;

        for (int i = 0; i < n + 1; i++)
        {
            if (i < n)
            {
                int inputInteger = int.Parse(Console.ReadLine());
                numbers[i] = inputInteger;
            }
            else
            {
                l = ulong.Parse(Console.ReadLine());
            }     
        }

        string lToBinary = ConvertToBinary(l).PadLeft(64, '0');
        char[] bits = lToBinary.ToCharArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = bits.Length - 1; j >= 0; j-=2)
            {
                string numberToBinary = Convert.ToString(numbers[i], 2);
                int evenPositions = numberToBinary.Length;

                if (j == 63 - (evenPositions * 2))
                {
                    break;
                }
                else
                {
                    if (bits[j] == '0')
                    {
                        bitsChangeCount++;
                    }
                    bits[j] = '1';
                }
            }
        }

        int extractIndexStart = Array.IndexOf(bits, '1');
        StringBuilder newl = new StringBuilder();

        for (int i = extractIndexStart; i < bits.Length; i++)
        {
            newl.Append(bits[i]);
        }

        Console.WriteLine(Convert.ToUInt64(newl.ToString(), 2));
        Console.WriteLine(bitsChangeCount);
    }

    static string ConvertToBinary(ulong value)
    {
        if (value == 0) return "0";
        System.Text.StringBuilder b = new System.Text.StringBuilder();
        while (value != 0)
        {
            b.Insert(0, ((value & 1) == 1) ? '1' : '0');
            value >>= 1;
        }
        return b.ToString();
    }
}
