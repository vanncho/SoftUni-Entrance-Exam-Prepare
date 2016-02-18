using System;

class DoubleDowns
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[,] bits = new char[n, 31];

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            string number = Convert.ToString(num, 2).PadLeft(31, '0');

            for (int j = number.Length - 1; j >= 0; j--)
            {
                bits[i, j] = number[j];
            }
        }
        
        int vertical = 0;
        int rightDiagonal = 0;
        int leftDiagonal = 0;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 31 - 1; j >= 0; j--)
            {
                if (bits[i, j] == '1' && bits[i + 1, j] == '1')
                {
                    vertical++;
                }
                if (j < 30 && bits[i, j] == '1' && bits[i + 1, j + 1] == '1')
                {
                    rightDiagonal++;
                }
                if (j > 0 && bits[i, j] == '1' && bits[i + 1, j - 1] == '1')
                {
                    leftDiagonal++;
                }
            }
        }

        Console.WriteLine(rightDiagonal);
        Console.WriteLine(leftDiagonal);
        Console.WriteLine(vertical);
    }
}
