using System;

class LargestProductOfDigits
{
    static void Main()
    {
        string input = Console.ReadLine();

        int max = int.MinValue;

        for (int i = 0; i < input.Length - 5; i++)
        {
            int product = 0;

            int d1 = int.Parse(input[i].ToString());
            int d2 = int.Parse(input[i + 1].ToString());
            int d3 = int.Parse(input[i + 2].ToString());
            int d4 = int.Parse(input[i + 3].ToString());
            int d5 = int.Parse(input[i + 4].ToString());
            int d6 = int.Parse(input[i + 5].ToString());

            product = d1 * d2 * d3 * d4 * d5 * d6;

            if (product > max)
            {
                max = product;
            }
        }

        Console.WriteLine(max);
    }
}
