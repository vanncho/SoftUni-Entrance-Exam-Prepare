using System;

class ChessboardGame
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        int blackSum = 0;
        int whiteSum = 0;

        // black team
        for (int i = 0; i < input.Length; i+=2)
        {
            if (i > n * n - 1)
            {
                break;
            }

            int num = input[i];

            if (num >= 48 && num <= 57 ||
                num >= 97 && num <= 122)
            {
                blackSum += num;
            }
            if (num >= 65 && num <= 90)
            {
                whiteSum += num;
            }
        }

        // white team
        for (int j = 1; j < input.Length; j+=2)
        {
            if (j > n * n - 1)
            {
                break;
            }

            int num = input[j];

            if (num >= 48 && num <= 57 ||
                num >= 97 && num <= 122)
            {
                whiteSum += num;
            }
            if (num >= 65 && num <= 90)
            {
                blackSum += num;
            }
        }

        if (blackSum > whiteSum)
        {
            Console.WriteLine("The winner is: black team");
            Console.WriteLine(blackSum - whiteSum);
        }
        if (whiteSum > blackSum)
        {
            Console.WriteLine("The winner is: white team");
            Console.WriteLine(whiteSum - blackSum);
        }
        if (blackSum == whiteSum)
        {
            Console.WriteLine("Equal result: {0}", whiteSum);
        }
    }
}
