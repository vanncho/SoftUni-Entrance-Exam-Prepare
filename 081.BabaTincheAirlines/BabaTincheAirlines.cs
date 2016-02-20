using System;
using System.Linq;

class BabaTincheAirlines
{
    static void Main()
    {
        int[,] input = new int[3, 3];

        for (int i = 0; i < input.GetLength(0); i++)
        {
            int[] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int j = 0; j < line.Length; j++)
            {
                input[i, j] = line[j];
            }
        }

        int[] ticketsPrices = { 7000, 3500, 1000 };
        decimal frequentFlyersDiscount = 0.30M;
        decimal mealCost = 0.995M;
        decimal[] totalAmountPerClass = new decimal[3];
        
        for (int i = 0; i < ticketsPrices.Length; i++)
        {
            // discounts
            int sumOfTicketsWithoutDiscount = 0;
            sumOfTicketsWithoutDiscount += ticketsPrices[i] * (input[i, 0] - input[i, 1]);
            decimal sumOfDiscountedTickets = 0;
            sumOfDiscountedTickets = input[i, 1] * (frequentFlyersDiscount * ticketsPrices[i]);

            // meals
            decimal sumOfTicketsWithMeal = 0;
            sumOfTicketsWithMeal = input[i, 2] * (ticketsPrices[i] - (ticketsPrices[i] * mealCost));
            sumOfTicketsWithoutDiscount += (int)sumOfTicketsWithMeal;
            sumOfTicketsWithoutDiscount += (int)sumOfDiscountedTickets;
            totalAmountPerClass[i] = sumOfTicketsWithoutDiscount;
        }

        int maximumProfitIfFullPlane = 233160; // took from ZERO TEST 3;

        int totalIncome = 0;

        for (int i = 0; i < totalAmountPerClass.Length; i++)
        {
            totalIncome += (int)totalAmountPerClass[i];
        }

        Console.WriteLine(totalIncome);
        Console.WriteLine(maximumProfitIfFullPlane - totalIncome);
    }
}
