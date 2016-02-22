using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BitLock
{
    static char[,] numbersAsBits = new char[8, 12];

    static void Main()
    {
        int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        numbersAsBits = FillMatrixWithBits(integers);

        List<int> bitsCounts = new List<int>();

        while (true)
        {
            string[] readCommand = Console.ReadLine().Split();

            if (readCommand[0] == "end")
            {
                break;
            }
            if (readCommand.Length == 2)
            {
                int colToCheck = 11 - int.Parse(readCommand[1]);
                int onesCount = 0;

                for (int i = 0; i < numbersAsBits.GetLength(0); i++)
                {
                    if (numbersAsBits[i, colToCheck] == '1')
                    {
                        onesCount++;
                    }
                }

                bitsCounts.Add(onesCount);
            }
            else
            {
                int row = int.Parse(readCommand[0]);
                string direction = readCommand[1];
                int countRotations = int.Parse(readCommand[2]);

                RollCurrentLineOfBits(row, direction, countRotations);
            }
        }

        // print bits counts
        for (int i = 0; i < bitsCounts.Count; i++)
        {
            Console.WriteLine(bitsCounts[i]);
        }

        // print numbers
        for (int i = 0; i < numbersAsBits.GetLength(0); i++)
        {
            StringBuilder result = new StringBuilder();
        
            for (int j = 0; j < numbersAsBits.GetLength(1); j++)
            {
                result.Append(numbersAsBits[i, j]);
            }
        
            int num = Convert.ToInt32(result.ToString(), 2);
        
            if (i < numbersAsBits.GetLength(0) - 1)
            {
                Console.Write("{0} ", num);
            }
            else
            {
                Console.WriteLine("{0}", num);
            }
        
        }

        //// print table
        //for (int i = 0; i < numbersAsBits.GetLength(0); i++)
        //{
        //    for (int j = 0; j < numbersAsBits.GetLength(1); j++)
        //    {
        //        Console.Write(" {0} ", numbersAsBits[i, j]);
        //    }
        //    Console.WriteLine();
        //}
    }

    static void RollCurrentLineOfBits(int row, string direction, int countRotations)
    {
        StringBuilder processBits = ExtractBitsFromGivenRow(row);
        char swap = new char();

        if (direction == "right")
        {   
            for (int i = 0; i < countRotations; i++)
            {
                swap = processBits[11];
                processBits.Remove(11, 1);
                processBits.Insert(0, swap);
            }

            //if (processBits[0] != processBits[11])
            //{
            //    swap = processBits[11];
            //    processBits[11] = processBits[0];
            //    processBits[0] = swap;
            //}
        }

        if (direction == "left")
        {
            for (int i = 0; i < countRotations; i++)
            {
                swap = processBits[0];
                processBits.Remove(0, 1);
                processBits.Insert(11, swap);
            }

            //if (processBits[0] != processBits[11])
            //{
            //    swap = processBits[0];
            //    processBits[0] = processBits[11];
            //    processBits[11] = swap;
            //}
        }
        // set new bits order to matrix
        for (int i = 0; i < numbersAsBits.GetLength(1); i++)
        {
            numbersAsBits[row, i] = processBits[i];
        }
    }

    static StringBuilder ExtractBitsFromGivenRow(int row)
    {
        StringBuilder processBits = new StringBuilder();

        for (int i = 0; i < numbersAsBits.GetLength(1); i++)
        {
            processBits.Append(numbersAsBits[row, i]);
        }

        return processBits;
    }

    static char[,] FillMatrixWithBits(int[] integers)
    {
        for (int i = 0; i < numbersAsBits.GetLength(0); i++)
        {
            string currentNumberToBinary = Convert.ToString(integers[i], 2).PadLeft(12, '0');

            for (int j = 0; j < numbersAsBits.GetLength(1); j++)
            {
                numbersAsBits[i, j] = currentNumberToBinary[j];
            }
        }

        return numbersAsBits;
    }
}
