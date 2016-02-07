using System;

class HayvanNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool isFound = false;

        for (int i = 555; i <= 999; i++)
        {
            int abc = i;
            int def = abc + diff;
            int ghi = def + diff;

            if (ghi > 999)
            {
                break;
            }

            string wholeNumber = "" + abc + def + ghi;

            if (wholeNumber.Contains("0") ||
                wholeNumber.Contains("1") ||
                wholeNumber.Contains("2") ||
                wholeNumber.Contains("3") ||
                wholeNumber.Contains("4"))
            {
                continue;
            }

            int targetSum = 0;
            for (int k = 0; k < wholeNumber.Length; k++)
            {
                targetSum += Convert.ToInt32(wholeNumber[k].ToString());   
            }

            if (targetSum == sum)
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
