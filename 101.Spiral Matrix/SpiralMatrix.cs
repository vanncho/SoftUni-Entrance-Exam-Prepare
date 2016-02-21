using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string word = Console.ReadLine().ToLower();

        char[,] matrix = FillTheMatrixWithLetters(word, n);

        int maxSum = int.MinValue;
        int[] rowSums = new int[n];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int currentRowSum = 0;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                currentRowSum += (matrix[i, j] - 96) * 10;
            }

            if (currentRowSum > maxSum)
            {
                maxSum = currentRowSum;
            }

            rowSums[i] = currentRowSum;
        }

        int rowIndex = Array.IndexOf(rowSums, maxSum);

        Console.WriteLine("{0} - {1}", rowIndex, maxSum);

        //// print matrix
        //for (int i = 0; i < matrix.GetLength(0); i++)
        //{
        //    for (int j = 0; j < matrix.GetLength(1); j++)
        //    {
        //        Console.Write(" {0} ", matrix[i,j]);
        //    }
        //    Console.WriteLine();
        //}
    }

    static char[,] FillTheMatrixWithLetters(string word, int n)
    {
        char[,] matrix = new char[n, n];
        int top = 0;
        int bottom = n - 1;
        int left = 0;
        int right = n - 1;

        int count = 0;
        int letterIndex = 0;

        while (top <= bottom && left <= right)
        {
            // col++
            for (int col = left; col <= right; col++)
            {
                matrix[top, col] = word[letterIndex];
                count++;
                letterIndex = count % word.Length;
            }

            top++;
            // row++
            for (int row = top; row <= bottom; row++)
            {
                matrix[row, right] = word[letterIndex];
                count++;
                letterIndex = count % word.Length;
            }

            right--;
            // col--
            for (int col = right; col >= left; col--)
            {
                matrix[bottom, col] = word[letterIndex];
                count++;
                letterIndex = count % word.Length;
            }

            bottom--;
            // row--
            for (int row = bottom; row >= top; row--)
            {
                matrix[row, left] = word[letterIndex];
                count++;
                letterIndex = count % word.Length;
            }

            left++;
        }

        return matrix;
    }
}
