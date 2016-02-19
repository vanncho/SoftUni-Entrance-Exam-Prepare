using System;
using System.Numerics;

class TicTacToePower
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());

        int[,] matrix = new int[3, 3];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = v;
                v++;
            }
        }

        int index = 0;
        string XY = "" + x + y;

        switch (XY)
        {
            case "00": index = 1; break;
            case "10": index = 2; break;
            case "20": index = 3; break;

            case "01": index = 4; break;
            case "11": index = 5; break;
            case "21": index = 6; break;

            case "02": index = 7; break;
            case "12": index = 8; break;
            case "22": index = 9; break;
        }
        
        int number = matrix[y, x];
        BigInteger multiply = 1;
        BigInteger result = 0;
        int count = 1;

        while (count <= index)
        {
            result *= multiply;
            multiply *= number;
            count++;
        }
        Console.WriteLine(multiply);

        //// print matrix
        //for (int i = 0; i < matrix.GetLength(0); i++)
        //{
        //    for (int j = 0; j < matrix.GetLength(1); j++)
        //    {
        //        Console.Write("{0} ", matrix[i,j]);
        //    }
        //    Console.WriteLine();
        //}
    }
}
