using System;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int firstSum = 0;
        int secondSum = 0;

        for (int i = 0; i < 2 * n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (i < n)
            {
                firstSum += num;
            }
            else
            {
                secondSum += num;
            }
        }

        if (firstSum == secondSum)
        {
            Console.WriteLine("Yes, sum={0}", firstSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(firstSum - secondSum));
        }
    }
}