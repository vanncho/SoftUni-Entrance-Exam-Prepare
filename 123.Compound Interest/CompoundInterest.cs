using System;

class CompoundInterest
{
    static void Main()
    {
        decimal p = decimal.Parse(Console.ReadLine());
        decimal n = decimal.Parse(Console.ReadLine());
        decimal i = decimal.Parse(Console.ReadLine());
        decimal f = decimal.Parse(Console.ReadLine());

        decimal interestRate = 1M + i;
        decimal result = 1;

        // calculate i to pow
        for (int j = 0; j < n; j++)
        {
            result *= interestRate;
        }

        decimal bankLoan = p * result;
        decimal friendLoan = p * (1 + f);

        if (bankLoan < friendLoan)
        {
            Console.WriteLine("{0:f2} Bank", bankLoan);
        }
        else if (bankLoan > friendLoan)
        {
            Console.WriteLine("{0:f2} Friend", friendLoan);
        }
        else
        {
            Console.WriteLine("{0:f2} Friend", friendLoan);
        }
    }
}
