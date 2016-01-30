using System;

class MagicCarNumbers
{
    static void Main()
    {
        int magicWeight = int.Parse(Console.ReadLine());

        char[] letters = new char[] { ' ', 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        int count = 0;

        for (int d1 = 0; d1 <= 9; d1++)
        {
            for (int d2 = 0; d2 <= 9; d2++)
            {
                for (int d3 = 0; d3 <= 9; d3++)
                {
                    for (int d4 = 0; d4 <= 9; d4++)
                    {
                        for (int j = 1; j < letters.Length; j++)
                        {
                            for (int k = 1; k < letters.Length; k++)
                            {
                                int sumOfCA = 40;
                                int letterJWeigth = (letters[j] - 64) * 10;
                                int letterKWeigth = (letters[k] - 64) * 10;
                                if ((sumOfCA + d1 + d2 + d3 + d4 + letterJWeigth + letterKWeigth == magicWeight) &&
                                    ((d1 == d2 && d2 == d3 && d3 == d4) ||
                                    (d2 == d3 && d3 == d4) ||
                                    (d1 == d2 && d2 == d3) ||
                                    (d1 == d2 && d3 == d4) ||
                                    (d1 == d3 && d2 == d4) ||
                                    (d1 == d4 && d2 == d3)))
                                {
                                    //Console.WriteLine("CA{0}{1}{2}{3}{4}{5}", d1, d2, d3, d4, letters[j], letters[k]);
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(count);
    }
}
