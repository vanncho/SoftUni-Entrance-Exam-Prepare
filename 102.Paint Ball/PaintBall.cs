using System;
using System.Collections.Generic;
using System.Text;

class PaintBall
{
    static void Main()
    {
        char[,] canvas = {
                             {'1','1','1','1','1','1','1','1','1','1'},
                             {'1','1','1','1','1','1','1','1','1','1'},
                             {'1','1','1','1','1','1','1','1','1','1'},
                             {'1','1','1','1','1','1','1','1','1','1'},
                             {'1','1','1','1','1','1','1','1','1','1'},
                             {'1','1','1','1','1','1','1','1','1','1'},
                             {'1','1','1','1','1','1','1','1','1','1'},
                             {'1','1','1','1','1','1','1','1','1','1'},
                             {'1','1','1','1','1','1','1','1','1','1'},
                             {'1','1','1','1','1','1','1','1','1','1'},
                         };

        List<int> rows = new List<int>();
        List<int> cols = new List<int>();
        List<int> radius = new List<int>();

        while (true)
        {
            string line = Console.ReadLine();
            if (line == "End")
            {
                break;
            }
            else
            {
                string[] splitLine = line.Split();
                rows.Add(int.Parse(splitLine[0]));
                cols.Add(int.Parse(splitLine[1]));
                radius.Add(int.Parse(splitLine[2]));
            }
        }

        for (int i = 0; i < rows.Count; i++)
        {
            int startCol = 9 - Math.Max(cols[i] - radius[i], 0);
            int endCol = 9 - Math.Min(cols[i] + radius[i], 9);
            int startRow = Math.Max(rows[i] - radius[i], 0);
            int endRow = Math.Min(rows[i] + radius[i], 9);

            int paint = i % 2;
            char currentPaint = Convert.ToChar(paint.ToString());

            int innerMatrixDimmentions = 1 + (2 * radius[i]);
            //char[,] innerMatrix = new char[innerMatrixDimmentions, innerMatrixDimmentions];

            //int startToPaintRow = canvas[startRow, startCol];
            //int endToPaintRow = canvas[startRow, endCol];
            //int startToPaintCol = canvas[endRow, startCol];
            //int endToPaintCol = canvas[endRow, endCol];

            //for (int row = startToPaintRow; row <= endToPaintRow; row++)
            //{
            //    for (int col = startToPaintCol; col <= endToPaintCol; col++)
            //    {
            //        canvas[row, col] = currentPaint;
            //    }
            //}

            for (int row = startRow; row <= endRow; row++)
            {
                for (int col = endCol; col <= startCol; col++)
                {
                    canvas[row, col] = currentPaint;
                }
            }
        }

        int sum = 0;

        for (int i = 0; i < canvas.GetLength(0); i++)
        {
            StringBuilder currentBitLine = new StringBuilder();

            for (int j = 0; j < canvas.GetLength(1); j++)
            {
                currentBitLine.Append(canvas[i, j]);
            }

            int lineNumber = Convert.ToInt32(currentBitLine.ToString(), 2);
            sum += lineNumber;
        }

        Console.WriteLine(sum);
    }
}
