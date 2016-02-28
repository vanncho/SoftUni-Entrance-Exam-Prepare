using System;
using System.Collections.Generic;
using System.Text;

class WaveBits
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());

        string convertToBits = ConvertToBinary(number);
        char[] bits = convertToBits.ToCharArray();

        int indexOfZero = Array.IndexOf(bits, '0');
        int start = 0;
        int end = 0;
        bool foundSequnce = false;
        bool foundStart = false;
        bool firstSequense = false;

        List<int> startPositions = new List<int>();
        List<int> endPositions = new List<int>();
        List<int> lengthsOfPositions = new List<int>();
        int move = 1;

        StringBuilder temp = new StringBuilder();

        if (bits[0] == '1' && bits[1] == '0' && bits[2] == '1')
        {
            temp.Append("101");
            start = 0;
            end = 2;
            foundSequnce = true;
            firstSequense = true;
        }

        for (int i = 2; i < bits.Length; i += move)
        {
            if (i < bits.Length - 2 && bits[i] == '1' && bits[i + 1] == '0' && bits[i + 2] == '1')
            {
                foundSequnce = true;
                
                if (!foundStart)
                {
                    start = i;
                    foundStart = true;
                }
                end = i + 2;
                move = 2;
                if (firstSequense)
                {
                    temp.Append("101");
                    firstSequense = false;
                }
                else
                {
                    temp.Append("01");
                }
                
            }
            else if (i > bits.Length - 2 && bits[i - 1] == '0' && bits[i] == '1' && foundSequnce)
            {
                if (firstSequense)
                {
                    temp.Append("101");
                    firstSequense = false;
                }
                else
                {
                    temp.Append("01");
                }
                startPositions.Add(start);
                endPositions.Add(end);
                lengthsOfPositions.Add(1 + (end - start));
            }
            else if (foundSequnce)
            {
                startPositions.Add(start);
                endPositions.Add(end);
                lengthsOfPositions.Add(temp.Length);
                start = 0;
                end = 0;
                foundStart = false;
                foundSequnce = false;
                move = 1;
                temp.Clear();
                firstSequense = true;
            }
        }

        if (lengthsOfPositions.Count > 0)
        {
            int maxLength = int.MinValue;
            for (int i = 0; i < lengthsOfPositions.Count; i++)
            {
                int max = lengthsOfPositions[i];
                if (max > maxLength)
                {
                    maxLength = max;
                }
            }

            StringBuilder res = new StringBuilder();
            int indexOfMaxLength = lengthsOfPositions.LastIndexOf(maxLength);

            for (int i = 0; i < bits.Length; i++)
            {
                if (i >= startPositions[indexOfMaxLength] && i <= endPositions[indexOfMaxLength])
                {
                    continue;
                }
                else
                {
                    res.Append(bits[i]);
                }
            }

            ulong newNumber = Convert.ToUInt64(res.ToString(), 2);
            Console.WriteLine(newNumber);
        }
        else
        {
            Console.WriteLine("No waves found!");
        }
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
