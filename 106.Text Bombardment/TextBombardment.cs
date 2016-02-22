using System;
using System.Linq;
using System.Text;

class TextBombardment
{
    static void Main()
    {
        string text = Console.ReadLine();
        int line = int.Parse(Console.ReadLine());
        int[] columns = Console.ReadLine().Split().Select(int.Parse).ToArray();

        string[,] table = new string[(text.Length / line) + 2, line];

        int count = 0;
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                if (count < text.Length)
                {
                    table[i, j] = text[count].ToString();
                    count++;
                }
                else
                {
                    table[i, j] = null;
                }
            }
        }

        for (int i = 0; i < table.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                for (int k = 0; k < columns.Length; k++)
                {
                    if (j == columns[k] && k >= 0)
                    {
                        table[i, j] = ' '.ToString();
                        if (table[i + 1, j] == ' '.ToString())
                        {
                            columns[k] = -1;
                        }
                        break;
                    }
                }
            }
        }

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < table.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                if (table[i, j] != null)
                {
                    result.Append(table[i, j]);
                }
            }
        }

        Console.WriteLine(result.ToString());

        //// print table
        //for (int i = 0; i < table.GetLength(0); i++)
        //{
        //    for (int j = 0; j < table.GetLength(1); j++)
        //    {
        //        Console.Write(" {0} ", table[i,j]);
        //    }
        //    Console.WriteLine();
        //}
    }
}
