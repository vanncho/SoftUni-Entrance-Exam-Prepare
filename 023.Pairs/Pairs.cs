using System;
using System.Linq;

class Pairs
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int[] sums = new int[numbers.Length / 2];

        for (int i = 0, j = 0; i < numbers.Length; i+=2, j++)
        {
            int sum = numbers[i] + numbers[i + 1];
            sums[j] = sum;
        }

        int diff = 0;

        for (int i = 0; i < sums.Length - 1; i++)
        {
            if (Math.Abs(sums[i] - sums[i + 1]) > diff)
                diff = Math.Abs(sums[i] - sums[i + 1]);
        }

        if (diff == 0)
        {
            Console.WriteLine("Yes, value={0}", sums[0]);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", diff);
        }
    }
}