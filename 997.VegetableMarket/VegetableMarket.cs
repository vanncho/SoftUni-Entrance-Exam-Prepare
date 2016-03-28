namespace _997.VegetableMarket
{
    using System;
    using System.Collections.Generic;

    public class VegetableMarket
    {
        public static void Main(string[] args)
        {
            double oneEuro = 1.94d;
            double vegPricePerKilo = double.Parse(Console.ReadLine()) / oneEuro;
            double fruitPricePerKilo = double.Parse(Console.ReadLine()) / oneEuro;
            int vegTotalKilos = int.Parse(Console.ReadLine());
            int fruitTotalKilos = int.Parse(Console.ReadLine());

            double vegCost = vegPricePerKilo * vegTotalKilos;
            double fruitCost = fruitPricePerKilo * fruitTotalKilos;

            double total = vegCost + fruitCost;

            Console.WriteLine(total);
        }
    }
}
