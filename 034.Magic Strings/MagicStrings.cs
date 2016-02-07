using System;

class MagicStrings
{
    static void Main()
    {
        char[] letters = {'k', 'n', 'p', 's' };
        int[] weight = { 1, 4, 5, 3 };

        int n = int.Parse(Console.ReadLine());
        bool isFound = false;

        for (int l1 = 0; l1 < 4; l1++)
        {
            for (int l2 = 0; l2 < 4; l2++)
            {
                for (int l3 = 0; l3 < 4; l3++)
                {
                    for (int l4 = 0; l4 < 4; l4++)
                    {
                        for (int l5 = 0; l5 < 4; l5++)
                        {
                            for (int l6 = 0; l6 < 4; l6++)
                            {
                                for (int l7 = 0; l7 < 4; l7++)
                                {
                                    for (int l8 = 0; l8 < 4; l8++)
                                    {
                                        int firstSum = weight[l1] + weight[l2] + weight[l3] + weight[l4];
                                        int secondSum = weight[l5] + weight[l6] + weight[l7] + weight[l8];
                                        int diff = Math.Abs(firstSum - secondSum);

                                        if (n == diff)
                                        {
                                            string sequence = "" + letters[l1] + letters[l2] + letters[l3] + letters[l4] + letters[l5] + letters[l6] + letters[l7] + letters[l8];
                                            Console.WriteLine(sequence);
                                            isFound = true;
                                        }
                                        
                                    }
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

