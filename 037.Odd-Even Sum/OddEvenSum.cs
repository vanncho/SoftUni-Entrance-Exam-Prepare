﻿using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int oddSum = 0;
        int evenSum = 0;

        for (int i = 0; i < 2 * n; i++)
        {
            int line = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                oddSum += line;
            }
            else
            {
                evenSum += line;
            }
        }

        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes, sum={0}", oddSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(oddSum - evenSum));
        }
    }
}
