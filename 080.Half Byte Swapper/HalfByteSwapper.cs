using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class HalfByteSwapper
{
    static void Main()
    {
        char[,] numbers = new char[4,32];
        FillTheNumbersArrayWithBits(numbers);

        List<int[]> lines = new List<int[]>();
        EnterLinesValues(lines);
        int commandCount = 0;
        int commandCount2 = 1;
        
        for (int i = 0; i < lines.Count / 2; i++)
        {
            char[] bitsFromFirstCommand = new char[4];
            char[] bitsFromSecondCommand = new char[4];

            int numberOfWordOne = lines[commandCount][0];
            int bitPosOne = GetStartPositionFormBinaryNumber(lines[commandCount][1]);
            bitsFromFirstCommand = GetBitsFromLine(numbers, bitPosOne, numberOfWordOne);
        
            int numberOfWordTwo = lines[commandCount2][0];
            int bitPosTwo = GetStartPositionFormBinaryNumber(lines[commandCount2][1]);
            bitsFromSecondCommand = GetBitsFromLine(numbers, bitPosTwo, numberOfWordTwo);
        
            for (int j = 4 - 1; j >= 0; j--)
            {
                numbers[numberOfWordOne, bitPosOne] = bitsFromSecondCommand[j];
                numbers[numberOfWordTwo, bitPosTwo] = bitsFromFirstCommand[j];
                bitPosOne--;
                bitPosTwo--;
            }
        
            commandCount += 2;
            commandCount2 += 2;
        }

        // print matrix
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write("{0} ", numbers[i,j]);
            }
            Console.WriteLine();
        }

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            StringBuilder n = new StringBuilder();

            for (int j = 0; j <  numbers.GetLength(1); j++)
            {
                n.Append(numbers[i, j]);
            }

            uint res = Convert.ToUInt32(n.ToString(), 2);
            Console.WriteLine(res);
        }
    }

    static int GetStartPositionFormBinaryNumber(int j)
    {
        j = 31 - (j * 4);

        return j;
    }

    static char[] GetBitsFromLine(char[,] numbers, int bitPos, int numberOfWord)
    {
        char[] array = new char[4];

        int count = 0;

        //for (int j = 0; j < array.Length; j++)
        for (int j = 4 - 1; j >= 0; j--)
        {
            array[count] = numbers[numberOfWord, bitPos - j];
            count++;
        }

        return array;
    }

    static void EnterLinesValues(List<int[]> lines)
    {
        while (true)
        {
            string command = Console.ReadLine();
            int[] line = new int[2];

            if (command != "End")
            {
                line = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            else
            {
                break;
            }

            lines.Add(line);
        }
    }

    static void FillTheNumbersArrayWithBits(char[,] numbers)
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            uint n = uint.Parse(Console.ReadLine());
            string line = Convert.ToString(n, 2).PadLeft(32, '0');

            for (int j = numbers.GetLength(1) - 1; j >= 0; j--)
            {
                numbers[i, j] = line[j];
            }
        }
    }
}
