using System;
using System.Collections.Generic;
using System.Text;

class BitsKiller
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        StringBuilder numbersAsBits = new StringBuilder();

        for (int i = 0; i < numbers; i++)
        {
            int bits = int.Parse(Console.ReadLine());
            string b = Convert.ToString(bits, 2);

            if (b.Length < 8)
            {
                numbersAsBits.Insert(numbersAsBits.Length, "0", (8 - b.Length));
            }
            numbersAsBits.Append(b);
            
        }

        string[] bitsToProcess = new string[numbers * 8];
        for (int fill = 0; fill < bitsToProcess.Length; fill++)
        {
            bitsToProcess[fill] = numbersAsBits[fill].ToString();
        }

        for (int i = 1; i < bitsToProcess.Length; i+=step)
        {
            bitsToProcess[i] = null;
        }

        numbersAsBits.Clear();

        foreach (var bit in bitsToProcess)
        {
            if (bit != null)
            {
                numbersAsBits.Append(bit);
            }
        }

        if (numbersAsBits.Length % 8 != 0)
        {
            numbersAsBits.Insert(numbersAsBits.Length, "0", (8 -(numbersAsBits.Length % 8)));
        }

        for (int i = 0; i < numbersAsBits.Length; i+=8)
        {
            string temp = numbersAsBits.ToString().Substring(i, 8);
            int result = Convert.ToInt32(temp, 2);
            Console.WriteLine(result);
        }        
    }
}
