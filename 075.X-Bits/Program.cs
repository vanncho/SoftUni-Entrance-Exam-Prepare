using System;

class Program
{
    static void Main()
    {
        char[,] bits = new char[8, 31];

        for (int i = 0; i < 8; i++)
        {
            int num = int.Parse(Console.ReadLine());
            string line = Convert.ToString(num, 2).PadLeft(31, '0');

            for (int j = line.Length - 1; j >= 0; j--)
            {
                bits[i, j] = line[j];
            }
        }

        int count = 0;

        for (int row = 0; row < bits.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < bits.GetLength(1) - 2; col++)
            {
                if ((bits[row, col] == '1' && bits[row, col + 1] == '0' && bits[row, col + 2] == '1') &&
                    (bits[row + 1, col] == '0' && bits[row + 1, col + 1] == '1' && bits[row + 1, col + 2] == '0') &&
                    (bits[row + 2, col] == '1' && bits[row + 2, col + 1] == '0' && bits[row + 2, col + 2] == '1'))
                {
                    count++;   
                }
            }
        }

        Console.WriteLine(count);

        // print matrix
        for (int i = 0; i < bits.GetLength(0); i++)
        {
            for (int j = 0; j < bits.GetLength(1); j++)
            {
                Console.Write("{0} ", bits[i,j]);
            }
            Console.WriteLine();
        }
    }
}
