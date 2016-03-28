namespace _998.PoolPipes
{
    using System;
    using System.Collections.Generic;

    public class PoolPipes
    {
        public static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int pOne = int.Parse(Console.ReadLine());
            int pTwo = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double pOneFullForH = (double)pOne * h;
            double pTwoFullForH = (double)pTwo * h;

            double percentsPoolFull = ((pOneFullForH + pTwoFullForH) / v) * 100;
            double percntsPipeOne = Math.Floor((pOneFullForH / (pOneFullForH + pTwoFullForH)) * 100);
            double percntsPipeTwo = Math.Floor((pTwoFullForH / (pOneFullForH + pTwoFullForH)) * 100);

            if ((pOneFullForH + pTwoFullForH) <= v)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", (int)percentsPoolFull, (int)percntsPipeOne, (int)percntsPipeTwo);
            }
            else
            {
                double overFlows = Math.Abs(v - (pOneFullForH + pTwoFullForH));

                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", h, overFlows);
            }
        }
    }
}
