using System;
using System.Text;

class BullsAndCows
{
    static void Main()
    {
        string line = Console.ReadLine();
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        bool isFound = false;

        string[] secretNumber = new string[line.Length];
        
        for (int i = 0; i < secretNumber.Length; i++)
        {
            secretNumber[i] = line[i].ToString();
        }

        for (int d1 = 1; d1 <= 9; d1++)
        {
            for (int d2 = 1; d2 <= 9; d2++)
            {
                for (int d3 = 1; d3 <= 9; d3++)
                {
                    for (int d4 = 1; d4 <= 9; d4++)
                    {
                        int bCount = 0;
                        int cCount = 0;
                        string[] digits = new string[line.Length];
                        digits[0] = d1.ToString();
                        digits[1] = d2.ToString();
                        digits[2] = d3.ToString();
                        digits[3] = d4.ToString();

                        for (int i = 0; i < secretNumber.Length; i++)
                        {
                            if (secretNumber[i] == digits[i])
                            {
                                bCount++;
                                digits[i] = null;
                                secretNumber[i] = null;
                            }
                        }
                        int tempCount = -1;
                        foreach (var digit in digits)
                        {
                            tempCount++;
                            if (digit != null)
                            {
                                for (int i = 0; i < secretNumber.Length; i++)
                                {
                                    if (digit.ToString() == secretNumber[i])
                                    {
                                        cCount++;
                                        secretNumber[i] = null;
                                        digits[tempCount] = null;
                                        break;
                                    }
                                }
                            }
                        }

                        if (bCount == b && cCount == c)
                        {
                            Console.Write("{0}{1}{2}{3} ", d1, d2, d3, d4);
                            isFound = true;
                        }

                        secretNumber[0] = line[0].ToString();
                        secretNumber[1] = line[1].ToString();
                        secretNumber[2] = line[2].ToString();
                        secretNumber[3] = line[3].ToString();
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
