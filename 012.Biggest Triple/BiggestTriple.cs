using System;
using System.Collections.Generic;
using System.Linq;

class BiggestTriple
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] split = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        List<int> sumOfTriples = new List<int>();
        List<int> startIndexs = new List<int>();

        int splitLength = split.Length;
        int restOfSequence = 0;
        int numberOfTripplesToTake = 0;

        if (splitLength % 3 != 0)
        {
            restOfSequence = splitLength % 3;
            numberOfTripplesToTake = splitLength / 3;
        }
        else
        {
            numberOfTripplesToTake = splitLength / 3;
        }

        int tempSum = 0;
        int index = 0;

        for (int j = 0; j < numberOfTripplesToTake; j++)
        {
            tempSum += split[index] + split[index + 1] + split[index + 2];
            sumOfTriples.Add(tempSum);
            startIndexs.Add(index);
            tempSum = 0;
            index += 3;
        }

        if (restOfSequence > 0)
        {
            tempSum = 0;
            startIndexs.Add(index);
            for (int i = index; i < split.Length; i++)
            {
                tempSum += split[i];
            }
            sumOfTriples.Add(tempSum);
        }

        tempSum = int.MinValue;
        tempSum = FindMaxSumInSequences(sumOfTriples);
        int maxSumIndex = sumOfTriples.IndexOf(tempSum);
        index = 0;

        for (int i = startIndexs[maxSumIndex]; i < split.Length; i++)
        {
            if (index < 3)
            {
                if (i < split.Length - 1)
                {
                    Console.Write("{0} ", split[i]);
                    index++;
                }
                else
                {
                    Console.Write("{0}", split[i]);
                    index++;
                }
            }
        }
        Console.WriteLine();
    }

    static int FindMaxSumInSequences(List<int> sumOfTriples)
    {
        int tempSum = 0;
        for (int i = 0; i < sumOfTriples.Count; i++)
        {
            if (tempSum < sumOfTriples[i])
            {
                tempSum = sumOfTriples[i];
            }
        }
        return tempSum;
    }
}
