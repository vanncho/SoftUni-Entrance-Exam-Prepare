using System;
using System.Numerics;

class CheatSheet
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        long verticallyStart = long.Parse(Console.ReadLine());
        long horizontallyStart = long.Parse(Console.ReadLine());

        BigInteger n = verticallyStart * horizontallyStart;
        BigInteger tempStart = n;

        BigInteger[,] matrix = new BigInteger[rows, cols];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = tempStart;
                tempStart += verticallyStart;
            }
            n += horizontallyStart;
            tempStart = n;
            verticallyStart++;

        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
