using System;

class MorseCodeNumbers
{
    static void Main()
    {
        //string inputNumber = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        string[] morseNumbers = { "-----", ".----", "..---", "...--", "....-", "....." };

        int nSum = 0;
        // 3333
        while (n > 0)
        {
            nSum += n % 10;
            n = n / 10;
        }
        //int nSum = 0;
        //for (int i = 0; i < inputNumber.Length; i++)
        //{
        //    nSum += int.Parse(inputNumber[i].ToString());
        //}

        bool isFound = false;

        for (int m1 = 0; m1 < 6; m1++)
        {
            for (int m2 = 0; m2 < 6; m2++)
            {
                for (int m3 = 0; m3 < 6; m3++)
                {
                    for (int m4 = 0; m4 < 6; m4++)
                    {
                        for (int m5 = 0; m5 < 6; m5++)
                        {
                            for (int m6 = 0; m6 < 6; m6++)
                            {
                                int product = m1 * m2 * m3 * m4 * m5 * m6;

                                if (product == nSum)
                                {
                                    Console.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|", morseNumbers[m1], morseNumbers[m2], morseNumbers[m3], morseNumbers[m4], morseNumbers[m5], morseNumbers[m6]);
                                    isFound = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        if (!isFound)
        {
            Console.WriteLine("No");
        }
    }
}
