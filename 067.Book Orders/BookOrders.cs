using System;

class BookOrders
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            int[] orders = new int[n];
            int[] packets = new int[n];
            decimal[] prices = new decimal[n];
            int allBoughtBook = 0;
            decimal allBooksCost = 0M;

            for (int i = 0; i < n; i++)
            {
                packets[i] = int.Parse(Console.ReadLine());
                orders[i] = int.Parse(Console.ReadLine());
                prices[i] = decimal.Parse(Console.ReadLine());

                int tempBoughtBooks = 0;
                tempBoughtBooks += orders[i] * packets[i];
                decimal discount = 0M;

                if (packets[i] < 10)
                {
                    discount = 1M;
                }
                //  10-19
                if (packets[i] >= 10 && packets[i] <= 19)
                {
                    discount = 0.95M;
                }
                // 20-29
                if (packets[i] >= 20 && packets[i] <= 29)
                {
                    discount = 0.94M;
                }
                // 30-39 
                if (packets[i] >= 30 && packets[i] <= 39)
                {
                    discount = 0.93M;
                }
                // 40-49 
                if (packets[i] >= 40 && packets[i] <= 49)
                {
                    discount = 0.92M;
                }
                // 50-59 
                if (packets[i] >= 50 && packets[i] <= 59)
                {
                    discount = 0.91M;
                }
                // 60-69 
                if (packets[i] >= 60 && packets[i] <= 69)
                {
                    discount = 0.90M;
                }
                // 70-79 
                if (packets[i] >= 70 && packets[i] <= 79)
                {
                    discount = 0.89M;
                }
                // 80-89 
                if (packets[i] >= 80 && packets[i] <= 89)
                {
                    discount = 0.88M;
                }
                // 90-99 
                if (packets[i] >= 90 && packets[i] <= 99)
                {
                    discount = 0.87M;
                }
                // 100-109 
                if (packets[i] >= 100 && packets[i] <= 109)
                {
                    discount = 0.86M;
                }
                // > 109
                if (packets[i] > 109)
                {
                    discount = 0.85M;
                }

                allBooksCost += (discount * prices[i]) * tempBoughtBooks;
                allBoughtBook += tempBoughtBooks;
            }

            Console.WriteLine(allBoughtBook);
            Console.WriteLine("{0:0.00}", allBooksCost);
        }
    }
}
