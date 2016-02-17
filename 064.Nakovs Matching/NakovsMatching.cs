using System;
using System.Text;

class NakovsMatching
{
    static void Main()
    {
        string firstString = Console.ReadLine();
        string secondString = Console.ReadLine();
        int limitNumber = int.Parse(Console.ReadLine());

        bool isMached = false;
        for (int i = 0; i < firstString.Length - 1; i++)
        {
            StringBuilder firstWordLeftPart = new StringBuilder();
            StringBuilder firstWordRightPart = new StringBuilder();
            int[] firstWord = new int[2];

            firstWordLeftPart.Insert(0, firstString.Substring(0, i + 1));
            firstWordRightPart.Insert(0, firstString.Substring(i + 1));

            for (int j = 0; j < firstWordLeftPart.Length; j++)
            {
                firstWord[0] += firstWordLeftPart[j];
            }

            for (int j = 0; j < firstWordRightPart.Length; j++)
            {
                firstWord[1] += firstWordRightPart[j];
            }

            for (int m = 0; m < secondString.Length - 1; m++)
            {
                StringBuilder secondWordLeftPart = new StringBuilder();
                StringBuilder secondWordRightPart = new StringBuilder();
                int[] secondWord = new int[2];

                secondWordLeftPart.Insert(0, secondString.Substring(0, m + 1));
                secondWordRightPart.Insert(0, secondString.Substring(m + 1));

                for (int j = 0; j < secondWordLeftPart.Length; j++)
                {
                    secondWord[0] += secondWordLeftPart[j];
                }

                for (int j = 0; j < secondWordRightPart.Length; j++)
                {
                    secondWord[1] += secondWordRightPart[j];
                }

                int match = Math.Abs(firstWord[0] * secondWord[1] - firstWord[1] * secondWord[0]);

                if (match <= limitNumber)
                {
                    Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs", firstWordLeftPart, firstWordRightPart, secondWordLeftPart, secondWordRightPart, match);
                    isMached = true;
                }
            }   
        }

        if (!isMached)
        {
            Console.WriteLine("No");
        }
    }
}
