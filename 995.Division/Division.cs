namespace _995.Division
{
    using System;
    using System.Collections.Generic;

    public class Division
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numOfP1 = 0;
            int numOfP2 = 0;
            int numOfP3 = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum % 2 == 0)
                {
                    numOfP1++;
                }

                if (currentNum % 3 == 0)
                {
                    numOfP2++;
                }

                if (currentNum % 4 == 0)
                {
                    numOfP3++;
                }
            }

            decimal p1Percents = ((decimal)numOfP1 / (decimal)n) * 100;
            decimal p2Percents = ((decimal)numOfP2 / (decimal)n) * 100;
            decimal p3Percents = ((decimal)numOfP3 / (decimal)n) * 100;

            Console.WriteLine("{0:f2}%", p1Percents);
            Console.WriteLine("{0:f2}%", p2Percents);
            Console.WriteLine("{0:f2}%", p3Percents);
        }
    }
}
