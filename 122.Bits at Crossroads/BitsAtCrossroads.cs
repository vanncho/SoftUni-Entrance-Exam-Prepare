using System;
using System.Text;

class BitsAtCrossroads
{
    static char[,] board;
    static int crossingsCount = 0;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        board = new char[n,n];
        int givenCrossings = 0;
        
        while (true)
        {
            string input = Console.ReadLine();
            if(input == "end")
            {
                break;
            }
            else
            {
                string[] coordinats = input.Split();
                int row = int.Parse(coordinats[0]);
                int col = (n - 1) - int.Parse(coordinats[1]);

                board[row, col] = '1';
                SetOnesToDiagonals(row, col, n);
                givenCrossings++;
            }    
        }

        for (int i = 0; i < board.GetLength(0); i++)
        {
            StringBuilder convertToBits = new StringBuilder();

            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i, j] == '\0')
                {
                    convertToBits.Append("0");
                }
                else
                {
                    convertToBits.Append("1");
                }
            }
            ulong num = Convert.ToUInt64(convertToBits.ToString(), 2);
            Console.WriteLine(num);
        }

        Console.WriteLine(crossingsCount + givenCrossings);
        //// print board
        //for (int i = 0; i < board.GetLength(0); i++)
        //{
        //    for (int j = 0; j < board.GetLength(1); j++)
        //    {
        //        Console.Write("{0}", board[i,j]);
        //    }
        //    Console.WriteLine();
        //}
    }

    static void SetOnesToDiagonals(int row, int col, int n)
    {
        int startRow = row;
        int startCol = col;

        // to top left
        while (true)
        {
            row--;
            col--;
            if (row < 0 || col < 0)
            {
                break;
            }
            else
            {
                if (board[row, col] == '1')
                {
                    crossingsCount++;
                }
                board[row, col] = '1';
                //row--;
                //col--;
            }
        }

        row = startRow;
        col = startCol;

        // to top right
        while (true)
        {
            row--;
            col++;
            if (row < 0 || col > n - 1)
            {
                break;
            }
            else
            {
                if (board[row, col] == '1')
                {
                    crossingsCount++;
                }
                board[row, col] = '1';
                //row--;
                //col++;
            }
        }

        row = startRow;
        col = startCol;

        // to down left
        while (true)
        {
            row++;
            col--;
            if (row >  n - 1 || col < 0)
            {
                break;   
            }
            else
            {
                if (board[row, col] == '1')
                {
                    crossingsCount++;
                }
                board[row, col] = '1';
                //row++;
                //col--;
            }
        }

        row = startRow;
        col = startCol;

        // to down right
        while (true)
        {
            row++;
            col++;
            if (row > n - 1 || col > n - 1)
            {
                break;
            }
            else
            {
                if (board[row, col] == '1')
                {
                    crossingsCount++;
                }
                board[row, col] = '1';
                //row++;
                //col++;
            }
        }
    }
}
