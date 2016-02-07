using System;
using System.Collections.Generic;
using System.Text;

class BitSifting
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        int numberOfSieves = int.Parse(Console.ReadLine());

        string[] nSieves = new string[numberOfSieves];
        string nToBits = ConvertToBinary(n).PadLeft(64, '0');
        StringBuilder nToSb = new StringBuilder(nToBits);

        for (int i = 0; i < numberOfSieves; i++)
        {
            string currentLineToBits = ConvertToBinary(ulong.Parse(Console.ReadLine())).PadLeft(64, '0');
            nSieves[i] = currentLineToBits;
        }


        StringBuilder finalBits = new StringBuilder();

        for (int j = 0; j < 63; j++)
        {
            char nextBit = '0';
            //int index = j % numberOfSieves;
            //string currentSieve = nSieves[index];

            for (int i = 0; i < numberOfSieves; i++)
            {
                string currentSieve = nSieves[i];
                if (nToBits[j] == '1' && currentSieve[j] == '1')
                {
                    nextBit = '0';
                    continue;
                }
                if (nToBits[j] == '1' && currentSieve[j] == '0')
                {
                    nextBit = '1';
                    continue;
                }   
            }
            finalBits.Append(nextBit);
        }



        ulong result = Convert.ToUInt64(finalBits.ToString(), 2);
        Console.WriteLine(result);
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
