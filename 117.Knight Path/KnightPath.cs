using System;
using System.Text;

class KnightPath
{
    static void Main()
    {
        string input = Console.ReadLine();

        char[,] board = FillBoardWithZeros();

        int currentRow = 0;
        int currentCol = 7;

        int lastRowPos = currentRow;
        int lastColPos = currentCol;

        board[currentRow, currentCol] = '1';

        do
        {
            switch (input)
            {
                case "left up":

                    if (currentCol < 2 && currentRow < 1)
                    {
                        break;
                    }

                    currentRow--;
                    currentCol -= 2;

                    if (currentRow < 0)
                    {
                        currentRow = lastRowPos;
                        currentCol = lastColPos;
                        break;
                    }
                    if (currentCol < 0)
                    {
                        currentRow = lastRowPos;
                        currentCol = lastColPos;
                        break;
                    }

                    lastRowPos = currentRow;
                    lastColPos = currentCol;

                    //board[currentRow, currentCol] = '1';
                    if (board[currentRow, currentCol] == '1')
                    {
                        board[currentRow, currentCol] = '0';
                        break;
                    }
                    if (board[currentRow, currentCol] == '0')
                    {
                        board[currentRow, currentCol] = '1';
                        break;
                    }
                    break;

                case "left down":

                    if (currentCol < 2 && currentRow > 6)
                    {
                        break;
                    }

                    currentRow++;
                    currentCol -= 2;

                    if (currentRow > 7)
                    {
                        currentRow = lastRowPos;
                        currentCol = lastColPos;
                        break;
                    }
                    if (currentCol < 0)
                    {
                        currentRow = lastRowPos;
                        currentCol = lastColPos;
                        break;
                    }

                    lastRowPos = currentRow;
                    lastColPos = currentCol;

                    //board[currentRow, currentCol] = '1';
                    if (board[currentRow, currentCol] == '1')
                    {
                        board[currentRow, currentCol] = '0';
                        break;
                    }
                    if (board[currentRow, currentCol] == '0')
                    {
                        board[currentRow, currentCol] = '1';
                        break;
                    }
                    break;

                case "right up":

                    if (currentCol > 5 && currentRow < 1) // ot ||
                    {
                        break;
                    }

                    currentRow--;
                    currentCol += 2;

                    if (currentRow < 0)
                    {
                        currentRow = lastRowPos;
                        currentCol = lastColPos;
                        break;
                    }
                    if (currentCol > 7)
                    {
                        currentRow = lastRowPos;
                        currentCol = lastColPos;
                        break;
                    }

                    lastRowPos = currentRow;
                    lastColPos = currentCol;

                    //board[currentRow, currentCol] = '1';
                    if (board[currentRow, currentCol] == '1')
                    {
                        board[currentRow, currentCol] = '0';
                        break;
                    }
                    if (board[currentRow, currentCol] == '0')
                    {
                        board[currentRow, currentCol] = '1';
                        break;
                    }
                    break;

                case "right down":

                    if (currentCol > 5 && currentRow > 6)
                    {
                        break;
                    }

                    currentRow++;
                    currentCol += 2;

                    if (currentRow > 7)
                    {
                        currentRow = lastRowPos;
                        currentCol = lastColPos;
                        break;
                    }
                    if (currentCol > 7)
                    {
                        currentRow = lastRowPos;
                        currentCol = lastColPos;
                        break;
                    }

                    lastRowPos = currentRow;
                    lastColPos = currentCol;

                    //board[currentRow, currentCol] = '1';
                    if (board[currentRow, currentCol] == '1')
                    {
                        board[currentRow, currentCol] = '0';
                        break;
                    }
                    if (board[currentRow, currentCol] == '0')
                    {
                        board[currentRow, currentCol] = '1';
                        break;
                    }
                    break;

                case "up left":

                    if (currentRow < 2 && currentCol < 1)
                    {
                        break;
                    }

                    currentRow -=2;
                    currentCol--;

                    if (currentRow < 0)
                    {
                        currentRow = lastRowPos;
                        currentCol = lastColPos;
                        break;
                    }
                    if (currentCol < 0)
                    {
                        currentRow = lastRowPos;
                        currentCol = lastColPos;
                        break;
                    }

                    lastRowPos = currentRow;
                    lastColPos = currentCol;

                    //board[currentRow, currentCol] = '1';
                    if (board[currentRow, currentCol] == '1')
                    {
                        board[currentRow, currentCol] = '0';
                        break;
                    }
                    if (board[currentRow, currentCol] == '0')
                    {
                        board[currentRow, currentCol] = '1';
                        break;
                    }
                    break;

                case "up right": 
                    
                    if (currentRow < 2 && currentCol < 7)
                    {
                        break;
                    }

                    currentRow -=2;
                    currentCol++;

                    if (currentRow < 0)
                    {
                        currentRow = lastRowPos;
                        currentCol = lastColPos;
                        break;
                    }
                    if (currentCol > 7)
                    {
                        currentRow = lastRowPos;
                        currentCol = lastColPos;
                        break;
                    }

                    lastRowPos = currentRow;
                    lastColPos = currentCol;

                    //board[currentRow, currentCol] = '1';
                    if (board[currentRow, currentCol] == '1')
                    {
                        board[currentRow, currentCol] = '0';
                        break;
                    }
                    if (board[currentRow, currentCol] == '0')
                    {
                        board[currentRow, currentCol] = '1';
                        break;
                    }
                    break;

                case "down left":

                    if (currentRow > 5 && currentCol < 1)
                    {
                        break;
                    }

                    currentRow +=2;
                    currentCol--;

                    if (currentRow > 7)
                    {
                        currentRow = lastRowPos;
                        currentCol = lastColPos;
                        break;
                    }
                    if (currentCol < 0)
                    {
                        currentRow = lastRowPos;
                        currentCol = lastColPos;
                        break;
                    }

                    lastRowPos = currentRow;
                    lastColPos = currentCol;

                    //board[currentRow, currentCol] = '1';
                    if (board[currentRow, currentCol] == '1')
                    {
                        board[currentRow, currentCol] = '0';
                        break;
                    }
                    if (board[currentRow, currentCol] == '0')
                    {
                        board[currentRow, currentCol] = '1';
                        break;
                    }
                    break;

                case "down right":

                    if (currentRow > 5 && currentCol > 6)
                    {
                        break;
                    }

                    currentRow+=2;
                    currentCol++;

                    if (currentRow > 7)
                    {
                        currentRow = lastRowPos;
                        currentCol = lastColPos;
                        break;
                    }
                    if (currentCol > 7)
                    {
                        currentRow = lastRowPos;
                        currentCol = lastColPos;
                        break;
                    }

                    lastRowPos = currentRow;
                    lastColPos = currentCol;

                    //board[currentRow, currentCol] = '1';
                    if (board[currentRow, currentCol] == '1')
                    {
                        board[currentRow, currentCol] = '0';
                        break;
                    }
                    if (board[currentRow, currentCol] == '0')
                    {
                        board[currentRow, currentCol] = '1';
                        break;
                    }
                    break;
            }
            input = Console.ReadLine();
        } while (input != "stop");

        bool printed = false;

        // print result
        for (int i = 0; i < board.GetLength(0); i++)
        {
            StringBuilder currentNumber = new StringBuilder();

            for (int j = 0; j < board.GetLength(1); j++)
            {
                currentNumber.Append(board[i,j]);
            }

            int num = Convert.ToInt32(currentNumber.ToString(), 2);
            if (num != 0)
            {
                Console.WriteLine(num);
                printed = true;
            }
        }

        if (!printed)
        {
            Console.WriteLine("[Board is empty]");
        }
    }

    static char[,] FillBoardWithZeros()
    {
        char[,] board = new char[8, 8];

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
