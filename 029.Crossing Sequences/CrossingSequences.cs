using System;
using System.Collections.Generic;
using System.Text;

class CrossingSequences
{
    static void Main()
    {
        int trib1 = int.Parse(Console.ReadLine());
        int trib2 = int.Parse(Console.ReadLine());
        int trib3 = int.Parse(Console.ReadLine());

        int init1 = int.Parse(Console.ReadLine());
        int init2 = int.Parse(Console.ReadLine());

        int tribonacciNext = 0;
        int spiralNumber = init1;
        int step = init2;
        int count = 0;
        int spiralCount = 0;

        List<int> tribonacciNumbers = new List<int>();
        tribonacciNumbers.Add(trib1);
        tribonacciNumbers.Add(trib2);
        tribonacciNumbers.Add(trib3);

        while (true)
        {
            tribonacciNext = trib1 + trib2 + trib3;

            if (tribonacciNext > 1000001)
            {
                break;
            }

            tribonacciNumbers.Add(tribonacciNext);

            trib1 = trib2;
            trib2 = trib3;
            trib3 = tribonacciNext;


        }

        int matchNumber = 0;
        while (true)
        {
            matchNumber = FindTheBothNumbers(tribonacciNumbers, spiralNumber);

            if (matchNumber != -1 || count == 1000001)
            {
                break;
            }

            if (spiralCount == 2)
            {
                spiralCount = 0;
                step += init2;
            }

            spiralNumber += step;
            spiralCount++;
            count++;
        }

        if (matchNumber < 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine(matchNumber);
        }

    }

    static int FindTheBothNumbers(List<int> tribonacciNumbers, int spiralNumber)
    {
        int n = -1;

        for (int i = 0; i < tribonacciNumbers.Count; i++)
        {
            if (tribonacciNumbers[i] <= spiralNumber)
            {
                if (tribonacciNumbers[i] == spiralNumber)
                {
                    return spiralNumber;
                }
            }
            else
            {
                break;
            }
        }

        return n;
    }
}