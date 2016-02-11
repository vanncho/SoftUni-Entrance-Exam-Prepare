using System;
using System.Collections.Generic;
using System.Linq;

class SequenceOfKNumbers
{
    static void Main()
    {
        string[] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int k = int.Parse(Console.ReadLine());

        string[] numbers = new string[k];
        int[] indexes = new int[k];

        if (k > 1)
        {
            for (int i = 0; i < line.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < k; j++)
                {
                    if (line.Length - i >= k)
                    {
                        numbers[j] = line[i + count];
                        indexes[j] = i + count;
                        count++;
                    }
                }

                bool allEqual = false;
                string firstDigit = numbers[0];

                for (int m = 1; m < numbers.Length; m++)
                {
                    if (numbers[m] == firstDigit && numbers[m] != null && firstDigit != null)
                    {
                        allEqual = true;
                        firstDigit = numbers[m];
                    }
                    else
                    {
                        allEqual = false;
                        break;
                    }
                }

                if (allEqual)
                {
                    for (int h = 0; h < indexes.Length; h++)
                    {
                        line[indexes[h]] = null;
                    }
                }
            }

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] != null)
                {
                    if (i < line.Length)
                    {
                        Console.Write("{0} ", line[i]);
                    }
                    else
                    {
                        Console.WriteLine("{0}", line[i]);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine();
        }
    }
}
