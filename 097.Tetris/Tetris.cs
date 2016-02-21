using System;

class Tetris
{
    static void Main()
    {
        string[] gameFieldDimentions = Console.ReadLine().Split();

        string[,] gameField = new string[int.Parse(gameFieldDimentions[0]), int.Parse(gameFieldDimentions[1])];

        for (int i = 0; i < gameField.GetLength(0); i++)
        {
            string line = Console.ReadLine();

            for (int j = 0; j < gameField.GetLength(1); j++)
            {
                gameField[i, j] = line[j].ToString();
            }
        }

        int Icount = 0;

        for (int i = 0; i < gameField.GetLength(0) - 3; i++)
        {
            for (int j = 0; j < gameField.GetLength(1); j++)
            {
                // I
                if (gameField[i, j] == "o" &&
                    gameField[i + 1, j] == "o" &&
                    gameField[i + 2, j] == "o" &&
                    gameField[i + 3, j] == "o")
                {
                    Icount++;
                }
            }
        }

        int Lcount = 0;

        for (int i = 0; i < gameField.GetLength(0) - 2; i++)
        {
            for (int j = 0; j < gameField.GetLength(1) - 1; j++)
            {
                // L
                if (gameField[i, j] == "o" &&
                    gameField[i + 1, j] == "o" &&
                    gameField[i + 2, j] == "o" &&
                    gameField[i + 2, j + 1] == "o")
                {
                    Lcount++;
                }
            }
        }

        int Jcount = 0;

        for (int i = 0; i < gameField.GetLength(0) - 2; i++)
        {
            for (int j = 0; j < gameField.GetLength(1) - 1; j++)
            {
                // J
                if (gameField[i, j + 1] == "o" &&
                    gameField[i + 1, j + 1] == "o" &&
                    gameField[i + 2, j + 1] == "o" &&
                    gameField[i + 2, j] == "o")
                {
                    Jcount++;
                }
            }
        }

        int Ocount = 0;

        for (int i = 0; i < gameField.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < gameField.GetLength(1) - 1; j++)
            {
                // O
                if (gameField[i, j] == "o" &&
                    gameField[i, j + 1] == "o" &&
                    gameField[i + 1, j] == "o" &&
                    gameField[i + 1, j + 1] == "o")
                {
                    Ocount++;
                }
            }
        }

        int Zcount = 0;

        for (int i = 0; i < gameField.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < gameField.GetLength(1) - 2; j++)
            {
                // Z
                if (gameField[i, j] == "o" &&
                    gameField[i, j + 1] == "o" &&
                    gameField[i + 1, j + 1] == "o" &&
                    gameField[i + 1, j + 2] == "o")
                {
                    Zcount++;
                }
            }
        }

        int Scount = 0;

        for (int i = 0; i < gameField.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < gameField.GetLength(1) - 2; j++)
            {
                // S
                if (gameField[i, j + 1] == "o" &&
                    gameField[i, j + 2] == "o" &&
                    gameField[i + 1, j] == "o" &&
                    gameField[i + 1, j + 1] == "o")
                {
                    Scount++;
                }
            }
        }

        int Tcount = 0;

        for (int i = 0; i < gameField.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < gameField.GetLength(1) - 2; j++)
            {
                // T
                if (gameField[i, j] == "o" &&
                    gameField[i, j + 1] == "o" &&
                    gameField[i, j + 2] == "o" &&
                    gameField[i + 1, j + 1] == "o")
                {
                    Tcount++;
                }
            }
        }

        Console.WriteLine("I:{0}, L:{1}, J:{2}, O:{3}, Z:{4}, S:{5}, T:{6}", Icount, Lcount, Jcount, Ocount, Zcount, Scount, Tcount);
        //// print gameField
        //for (int i = 0; i < gameField.GetLength(0); i++)
        //{
        //    for (int j = 0; j < gameField.GetLength(1); j++)
        //    {
        //        Console.Write("{0}", gameField[i,j]);
        //    }
        //    Console.WriteLine();
        //}
    }
}
