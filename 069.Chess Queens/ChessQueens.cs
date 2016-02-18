using System;

class ChessQueens
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        int[,] board = new int[n, n];
        bool isFound = false;

        for (int qRow1 = 0; qRow1 < board.GetLength(0); qRow1++)
        {
            for (int qCol1 = 0; qCol1 < board.GetLength(1); qCol1++)
            {
                for (int qRow2 = 0; qRow2 < board.GetLength(0); qRow2++)
                {
                    for (int qCol2 = 0; qCol2 < board.GetLength(1); qCol2++)
                    {
                        bool x = qRow1 == qRow2 && Math.Abs(qCol1 - qCol2) == d + 1;
                        bool y = qCol1 == qCol2 && Math.Abs(qRow1 - qRow2) == d + 1;
                        bool diagonal = Math.Abs(qRow1 - qRow2) == d + 1 && Math.Abs(qCol1 - qCol2) == d + 1;

                        if (x || y || diagonal)
                        {
                            char ch1 = Convert.ToChar(qRow1 + 97);
                            char ch2 = Convert.ToChar(qRow2 + 97);
                            Console.WriteLine("{0}{1} - {2}{3}", ch1, qCol1 + 1, ch2, qCol2 + 1);
                            isFound = true;
                        }
                    }
                }
            }
        }
        if (!isFound)
        {
            Console.WriteLine("No valid positions");
        }
    }
}
