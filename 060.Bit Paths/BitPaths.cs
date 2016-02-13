using System;
using System.Linq;

class BitPaths
{
    static void Main()
    {
        int[,] initialBoard = {
                                  {0,0,0,0},
                                  {0,0,0,0},
                                  {0,0,0,0},
                                  {0,0,0,0},
                                  {0,0,0,0},
                                  {0,0,0,0},
                                  {0,0,0,0},
                                  {0,0,0,0}
                              };

        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            string currentLine = Console.ReadLine();
            int[] boards = currentLine.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int currentCol = boards[0];
            //int cellValue = SetTheCellValue(initialBoard, currentCol, i);
            int cellValue = 1;

            if (initialBoard[0, currentCol] == 1)
            {
                cellValue = 0;
            }
            initialBoard[0, currentCol] = cellValue;

            for (int j = 1; j < boards.Length; j++)
            {
                currentCol += boards[j];
                cellValue = SetTheCellValue(initialBoard, currentCol, j);
                initialBoard[j, currentCol] = cellValue;
            }
        }


        for (int i = 0; i < initialBoard.GetLength(0); i++)
        {
            string binary = "";
            for (int j = 0; j < initialBoard.GetLength(1); j++)
            {
                binary += initialBoard[i, j];
            }
            sum += Convert.ToInt32(binary, 2);
        }

        Console.WriteLine(Convert.ToString(sum, 2));
        Console.WriteLine(Convert.ToString(sum, 16).ToUpper());

        //for (int row = 0; row < initialBoard.GetLength(0); row++)
        //{
        //    for (int col = 0; col < initialBoard.GetLength(1); col++)
        //    {
        //        Console.Write(" {0} ", initialBoard[row, col]);
        //    }
        //    Console.WriteLine();
        //}
    }

    static int SetTheCellValue(int[,] initialBoard, int currentCol, int j)
    {
        int cellValue;
        if (initialBoard[j, currentCol] == 0)
        {
            cellValue = 1;
        }
        else
        {
            cellValue = 0;
        }
        return cellValue;
    }
}
