using System;
using System.Linq;

class SumOfElements
{
    static void Main()
    {
        int[] sequence = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int max = int.MinValue;
        long sum = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] > max)
            {
                max = sequence[i];
            }
            sum += sequence[i];
        }

        if (max == sum - max)
        {
            Console.WriteLine("Yes, sum={0}", max);
        }
        else
        {
            long diff = Math.Abs(max - (sum - max));
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}
