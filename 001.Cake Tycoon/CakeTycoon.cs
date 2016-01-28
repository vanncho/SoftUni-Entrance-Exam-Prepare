using System;
class CakeTycoon
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine()); // amount of cakes Ivancho wants.
        decimal c = decimal.Parse(Console.ReadLine()); // kilograms of flour needed to make one cake.
        long f = uint.Parse(Console.ReadLine()); // kilograms of flour available.
        long t = uint.Parse(Console.ReadLine()); // amount of truffles available.
        long p = uint.Parse(Console.ReadLine()); // amount of truffles available.

        // Cakes he can make
        decimal cakesHeCanMake = (f / c); // 4621.371477495885

        long trufflesCost = t * p;
        decimal ddd = (decimal)trufflesCost / n;
        decimal cakePrice = 1.25m * ddd;
        decimal TotalFlourRequired = n * c;
        decimal kilogramsFlourNeeded = TotalFlourRequired - f;

        if (cakesHeCanMake < n)
        {
            Console.WriteLine("Can make only {0} cakes, need {1:0.00} kg more flour", (int)cakesHeCanMake, kilogramsFlourNeeded);
        }
        if (cakesHeCanMake >= n)
        {
            Console.WriteLine("All products available, price of a cake: {0:0.00}", cakePrice);
        }
        
    }
}
