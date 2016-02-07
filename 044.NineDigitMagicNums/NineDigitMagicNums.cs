using System;

class NineDigitMagicNums
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        bool isFound = false;

        for (int i = 111; i <= 777; i++)
        {
            int abc = i;
            int def = i + diff;
            int ghi = def + diff;

            string wholeNumber = "" + abc + def + ghi;

            if (wholeNumber.Contains("0") ||
                wholeNumber.Contains("8") ||
                wholeNumber.Contains("9"))
            {
                continue;
            }

            int tempSum = 0;
            for (int j = 0; j < wholeNumber.Length; j++)
            {
                int digit = int.Parse(wholeNumber[j].ToString());
                tempSum += digit;
            }

            if (tempSum == sum && wholeNumber.Length == 9)
            {
                Console.WriteLine(wholeNumber);
                isFound = true;
            }
        }

        if (!isFound)
        {
            Console.WriteLine("No");
        }
    }
}
