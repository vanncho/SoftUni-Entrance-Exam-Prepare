using System;

class OddOrEvenCounter
{
    static void Main()
    {
        int nCountOfSets = int.Parse(Console.ReadLine());
        int cNumbersInSets = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();

        int[,] numbers = new int[nCountOfSets, cNumbersInSets];
        int[] evenSets = new int[nCountOfSets];
        int[] oddSets = new int[nCountOfSets];

        bool foundEven = false;
        bool foundOdd = false;

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            int oddCount = 0;
            int evenCount = 0;

            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
        
                if (currentNumber % 2 == 0)
                {
                    evenCount++;
                    foundEven = true;
                }
                else
                {
                    oddCount++;
                    foundOdd = true;
                }
        
                numbers[i, j] = currentNumber;
            }

            evenSets[i] = evenCount;
            oddSets[i] = oddCount;
        }

        int max = int.MinValue;
        int setNumber = 0;
        string setNumberAsWord = "";

        if (s == "odd")
        {
            if (foundOdd)
            {
                for (int i = 0; i < oddSets.Length; i++)
                {
                    if (oddSets[i] > max)
                    {
                        max = oddSets[i];
                        setNumber = i + 1;
                    }
                }

                switch (setNumber)
                {
                    case 1: setNumberAsWord = "First"; break;
                    case 2: setNumberAsWord = "Second"; break;
                    case 3: setNumberAsWord = "Third"; break;
                    case 4: setNumberAsWord = "Fourth"; break;
                    case 5: setNumberAsWord = "Fifth"; break;
                    case 6: setNumberAsWord = "Sixth"; break;
                    case 7: setNumberAsWord = "Seventh"; break;
                    case 8: setNumberAsWord = "Eighth"; break;
                    case 9: setNumberAsWord = "Ninth"; break;
                    case 10: setNumberAsWord = "Tenth"; break;
                }

                Console.WriteLine("{0} set has the most {1} numbers: {2}", setNumberAsWord, s, max);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        else
        {
            if (foundEven)
            {
                for (int i = 0; i < evenSets.Length; i++)
                {
                    if (evenSets[i] > max)
                    {
                        max = evenSets[i];
                        setNumber = i + 1;
                    }
                }

                switch (setNumber)
                {
                    case 1: setNumberAsWord = "First"; break;
                    case 2: setNumberAsWord = "Second"; break;
                    case 3: setNumberAsWord = "Third"; break;
                    case 4: setNumberAsWord = "Fourth"; break;
                    case 5: setNumberAsWord = "Fifth"; break;
                    case 6: setNumberAsWord = "Sixth"; break;
                    case 7: setNumberAsWord = "Seventh"; break;
                    case 8: setNumberAsWord = "Eighth"; break;
                    case 9: setNumberAsWord = "Ninth"; break;
                    case 10: setNumberAsWord = "Tenth"; break;
                }

                Console.WriteLine("{0} set has the most {1} numbers: {2}", setNumberAsWord, s, max);
            }
            else
            {
                Console.WriteLine("No");
            }
        }

    }
}
