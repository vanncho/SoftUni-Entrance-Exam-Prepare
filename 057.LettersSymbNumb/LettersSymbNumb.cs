using System;
using System.Text.RegularExpressions;

class LettersSymbNumb
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] lines = new string[n];
        int sumOfLetters = 0;
        int sumOfNumbers = 0;
        int sumOfSymbols = 0;

        for (int i = 0; i < n; i++)
        {
            string currentLine = Console.ReadLine();
            string[] splitedLine = currentLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < splitedLine.Length; j++)
            {
                for (int k = 0; k < splitedLine[j].Length; k++)
                {
                    char currentChar = splitedLine[j][k];

                    if (currentChar == '\t' || currentChar == '\r' || currentChar == '\n')
                    {
                        continue;
                    }

                    if (char.IsDigit(currentChar))
                    {
                        sumOfNumbers += (currentChar - 48) * 20;
                        continue;
                    }
                    if (char.IsLower(currentChar))
                    {
                        sumOfLetters += (currentChar - 96) * 10;
                        continue;
                    }
                    if (char.IsUpper(currentChar))
                    {
                        sumOfLetters += (currentChar - 64) * 10;
                        continue;
                    }
                    else
                    {
                        sumOfSymbols += 200;
                    }
                }
            }
        }

        Console.WriteLine(sumOfLetters);
        Console.WriteLine(sumOfNumbers);
        Console.WriteLine(sumOfSymbols);
    }
}
