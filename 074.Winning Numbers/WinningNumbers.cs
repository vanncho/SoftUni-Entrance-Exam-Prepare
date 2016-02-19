using System;

class WinningNumbers
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();

        int letSum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            letSum += s[i] - 96;
        }

        bool isFound = false;

        for (int right1 = 0; right1 <= 9; right1++)
        {
            for (int right2 = 0; right2 <= 9; right2++)
            {
                for (int right3 = 0; right3 <= 9; right3++)
                {
                    for (int left1 = 0; left1 <= 9; left1++)
                    {
                        for (int left2 = 0; left2 <= 9; left2++)
                        {
                            for (int left3 = 0; left3 <= 9; left3++)
                            {
                                int leftSum = left1 * left2 * left3;
                                int rightSum = right1 * right2 * right3;

                                if (leftSum == letSum && rightSum == letSum)
                                {
                                    Console.WriteLine("{0}{1}{2}-{3}{4}{5}", right1, right2, right3, left1, left2, left3);
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
