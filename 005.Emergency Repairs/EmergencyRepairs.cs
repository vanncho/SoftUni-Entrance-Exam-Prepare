using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Globalization;

class EmergencyRepairs
{
    static void Main()
    {
        ulong wallBeforeTheAttack = ulong.Parse(Console.ReadLine());
        int emergencyRepairKits = int.Parse(Console.ReadLine());
        int numberOfAttacks = int.Parse(Console.ReadLine());

        int[] bitToAttack = new int[numberOfAttacks];

        for (int i = 0; i < numberOfAttacks; i++)
        {
            int attack = int.Parse(Console.ReadLine());
            bitToAttack[i] = attack;
        }

        string bits = ConvertToBinary(wallBeforeTheAttack);
        var bitsToArray = BitsToListArray(bits);

        // Perform The Attack
        for (int i = 0; i < numberOfAttacks; i++)
        {
            if (bitsToArray[bitToAttack[i]] == 0)
            {
                continue;
            }
            else
            {
                bitsToArray[bitToAttack[i]] = 0;
            }
        }

        // Repair
        int repairs = emergencyRepairKits;

        for (int i = 0; i < bitsToArray.Length; i++)
        {
            if (repairs > 0)
            {
                if (bitsToArray[i] == 0 && bitsToArray[i + 1] == 0)
                {
                    if (repairs > 1)
                    {
                        bitsToArray[i] = 1;
                        bitsToArray[i + 1] = 1;
                        repairs -= 2;
                    }
                    else
                    {
                        bitsToArray[i] = 1;
                        repairs--;
                    }

                }
                else
                {
                    continue;
                }
            }
            else
            {
                break;
            }
        }


        StringBuilder res = new StringBuilder();

        Array.Reverse(bitsToArray);
        foreach (var digiChar in bitsToArray)
        {
            res.Append(digiChar);
        }

        int indexOfOne = res.ToString().IndexOf('1');
        string binaryRes = res.ToString().Substring(indexOfOne, 64 - indexOfOne);

        string finalResult = BinToDec(binaryRes);

        //ulong result = Convert.ToUInt64(binaryRes, 2);
        //BigInteger result = BigInteger.Parse(finalResult, 2);

        StringBuilder processTheFinalResult = new StringBuilder(finalResult);
        if (finalResult[0] == '-')
        {
            processTheFinalResult.Remove(0, 1);
        }

        Console.WriteLine(processTheFinalResult.ToString());
    }

    static string BinToDec(string value)
    {
        // BigInteger can be found in the System.Numerics dll
        BigInteger res = 0;

        // I'm totally skipping error handling here
        foreach (char c in value)
        {
            res <<= 1;
            res += c == '1' ? 1 : 0;
        }

        return res.ToString();
    }

    static int[] BitsToListArray(string bits)
    {
        int[] bitsToArray = new int[bits.Length];

        for (int i = 0; i < bitsToArray.Length; i++)
        {
            bitsToArray[i] = bits[i] - 48;
        }

        Array.Reverse(bitsToArray);
        return bitsToArray;
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

        int diff = 64 - b.Length;
        string tempBinary = b.ToString();
        b.Clear();
        b.Append('0', diff);
        b.Append(tempBinary);

        return b.ToString();
    }
}
