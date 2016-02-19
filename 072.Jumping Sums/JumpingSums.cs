using System;
using System.Linq;

class JumpingSums
{
    static void Main()
    {
        string line = Console.ReadLine();
        int j = int.Parse(Console.ReadLine());

        int[] numbers = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int[] sums = new int[numbers.Length];

        for (int index = 0; index < numbers.Length; index++)
        {
            int ind = index;
            sums[index] += numbers[ind];

            for (int jump = 0; jump < j; jump++)
            {
                ind += numbers[ind];

                if (ind >= numbers.Length)
                {
                    ind = ind % numbers.Length;
                }

                sums[index] += numbers[ind];    
            }
        }

        int maxSum = int.MinValue;
        for (int i = 0; i < sums.Length; i++)
        {
            if (sums[i] > maxSum)
            {
                maxSum = sums[i];
            } 
        }

        Console.WriteLine("max sum = {0}", maxSum);
    }
}
