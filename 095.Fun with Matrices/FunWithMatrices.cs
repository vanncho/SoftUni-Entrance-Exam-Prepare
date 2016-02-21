using System;
using System.Collections.Generic;

class FunWithMatrices
{
    static int rowIndex = 0;
    static int colIndex = 0;

    static void Main()
    {
        double[,] matrix = new double[4, 4];

        double startNumber = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());

        List<int> rows = new List<int>();
        List<int> cols = new List<int>();
        List<string> commands = new List<string>();
        List<double> num = new List<double>();

        while (true)
        {
            string line = Console.ReadLine();
            string[] input = line.Split();
            if (line == "Game Over!")
            {
                break;
            }
            else
            {
                rows.Add(int.Parse(input[0]));
                cols.Add(int.Parse(input[1]));
                commands.Add(input[2]);
                num.Add(double.Parse(input[3]));
            }
        }

        matrix = FillTheMatrixWithStartNumberAndStep(matrix, startNumber, step);

        for (int i = 0; i < commands.Count; i++)
        {
            double tempNum = 0;
            switch (commands[i])
            {
                case "multiply": tempNum = matrix[rows[i], cols[i]] * num[i];
                    matrix[rows[i], cols[i]] = tempNum; break;
                case "sum": tempNum = matrix[rows[i], cols[i]] + num[i]; 
                    matrix[rows[i], cols[i]] = tempNum; break;
                case "power": tempNum = Math.Pow(matrix[rows[i], cols[i]], num[i]); 
                    matrix[rows[i], cols[i]] = tempNum; break;
            }
        }

        double rowsMaxSum = FindRowsMaxSum(matrix);
        double colsMaxSum = FindColsMaxSum(matrix);
        double leftDiagonalSum = matrix[0, 0] + matrix[1, 1] + matrix[2, 2] + matrix[3, 3];
        double rightDiagonalSum = matrix[0, 3] + matrix[1, 2] + matrix[2, 1] + matrix[3, 0];

        if (rowsMaxSum == colsMaxSum && rowsMaxSum == leftDiagonalSum && rowsMaxSum == rightDiagonalSum)
        {
            Console.WriteLine("ROW[{0}] = {1:f2}", rowIndex, rowsMaxSum);
        }
        if (rowsMaxSum > colsMaxSum && rowsMaxSum > leftDiagonalSum && rowsMaxSum > rightDiagonalSum)
        {
            Console.WriteLine("ROW[{0}] = {1:f2}", rowIndex, rowsMaxSum);
        }
        if (colsMaxSum > rowsMaxSum && colsMaxSum > leftDiagonalSum && colsMaxSum > rightDiagonalSum)
        {
            Console.WriteLine("COLUMN[{0}] = {1:f2}", colIndex, colsMaxSum);
        }
        if (leftDiagonalSum > rowsMaxSum && leftDiagonalSum > colsMaxSum && leftDiagonalSum > rightDiagonalSum)
        {
            Console.WriteLine("LEFT-DIAGONAL = {0:f2}", leftDiagonalSum);
        }
        if (rightDiagonalSum > rowsMaxSum && rightDiagonalSum > colsMaxSum && rightDiagonalSum > leftDiagonalSum)
        {
            Console.WriteLine("RIGHT-DIAGONAL = {0:f2}", rightDiagonalSum);
        }
    }

    static double FindColsMaxSum(double[,] matrix)
    {
        double maxSum = double.MinValue;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            double currentSum = 0;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                currentSum += matrix[j, i];
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                colIndex = i;
            }
        }

        return maxSum;
    }

    static double FindRowsMaxSum(double[,] matrix)
    {
        double maxSum = double.MinValue;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            double currentSum = 0;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                currentSum += matrix[i, j];   
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                rowIndex = i;
            }
        }

        return maxSum;
    }

    static double[,] FillTheMatrixWithStartNumberAndStep(double[,] matrix, double startNumber, double step)
    {
        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                matrix[r, c] = startNumber;
                startNumber += step;
            }
        }

        return matrix;
    }
}
