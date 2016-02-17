using System;
using System.Collections.Generic;

class OddEvenJumps
{
    static void Main()
    {
        string[] stringEnter = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());

        string input = String.Join(" ", stringEnter);
        List<int> oddLetters = new List<int>();
        List<int> evenLetters = new List<int>();

        int posCount = 1;
        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = char.Parse((input[i].ToString()).ToLower());
            if (currentChar == ' ')
            {
                continue;
            }
            if (posCount % 2 != 0 && currentChar != ' ')
            {
                oddLetters.Add(currentChar);
            }
            if (posCount % 2 == 0 && currentChar != ' ')
            {
                evenLetters.Add(currentChar);
            }
            posCount++;
        }

        long oddResult = 0;
        int count = 1;

        for (int i = 0; i < oddLetters.Count; i++)
        {
            if (count == oddJump)
            {
                oddResult *= oddLetters[i];
                count = 1;
                continue;
            }
            oddResult += oddLetters[i];

            count++;
        }

        long evenResult = 0;
        count = 1;
        for (int i = 0; i < oddLetters.Count; i++)
        {
            if (i < evenLetters.Count)
            {
                if (count == evenJump)
                {
                    evenResult *= evenLetters[i];
                    count = 1;
                    continue;
                }
                evenResult += evenLetters[i];

                count++;
            }
            else
            {
                break;
            }

        }

        Console.WriteLine("Odd: {0}", Convert.ToString(oddResult, 16).ToUpper());
        Console.WriteLine("Even: {0}", Convert.ToString(evenResult, 16).ToUpper());
    }
}
