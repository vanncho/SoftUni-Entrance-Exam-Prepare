using System;

class GameOfLife
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char[,] board = FillBoardWithZeros();
        char[,] futureBoard = FillBoardWithZeros();
        int[,] coordinates = new int[n, 2];

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            int y = 9 - int.Parse(Console.ReadLine());

            coordinates[i, 0] = x;
            coordinates[i, 1] = y;

            board[x, y] = '1';
        }

        // search thru live cels
        for (int j = 0; j < coordinates.GetLength(0); j++)
        {
            char currentCell = board[coordinates[j, 0], coordinates[j, 1]];

            int rowStart = Math.Max(coordinates[j, 0] - 1, 0);
            int rowEnd = Math.Min(coordinates[j, 0] + 1, 9);
            int colStart = 9 - (Math.Max(9 - (coordinates[j, 1] - 1), 9 - coordinates[j, 1]));
            int colEnd = 9 - (Math.Min(9 - (coordinates[j, 1] + 1), 9 - coordinates[j, 1]));

            if (currentCell == '1')
            {
                int livesCount = 0;

                for (int k = rowStart; k <= rowEnd; k++)
                {
                    for (int l = colStart; l <= colEnd; l++)
                    {
                        if (board[k, l] == '1')
                        {
                            livesCount++;
                        }
                    }
                }

                if (livesCount - 1 < 2)
                {
                    futureBoard[coordinates[j, 0], coordinates[j, 1]] = '0';
                }
                else if (livesCount - 1 >= 2 && livesCount - 1 <= 3)
                {
                    futureBoard[coordinates[j, 0], coordinates[j, 1]] = '1';
                }
                else if (livesCount - 1 > 3)
                {
                    futureBoard[coordinates[j, 0], coordinates[j, 1]] = '0';
                }
            }
        }

        // seach thru dead cells
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                int rowStart = Math.Max(i - 1, 0);
                int rowEnd = Math.Min(i + 1, 9);
                int colStart = Math.Max(j - 1, 0);
                int colEnd = Math.Min(j + 1, 9);
        
                int livesCount = 0;
        
                for (int k = rowStart; k <= rowEnd; k++)
                {
                    for (int l = colStart; l <= colEnd; l++)
                    {
                        if (board[k, l] == '1')
                        {
                            livesCount++;
                        }
                    }
                }
        
                if (livesCount == 3)
                {
                    futureBoard[i, j] = '1';
                }
            }
        }

        // print board
        for (int i = 0; i < futureBoard.GetLength(0); i++)
        {
            for (int j = 0; j < futureBoard.GetLength(1); j++)
            {
                Console.Write(futureBoard[i, j]);
            }
            Console.WriteLine();
        }
    }

    static char[,] FillBoardWithZeros()
    {
        char[,] board = new char[10, 10];

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                board[i, j] = '0';
            }
        }

        return board;
    }
}
