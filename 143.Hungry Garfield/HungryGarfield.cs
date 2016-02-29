using System;

class HungryGarfield
{
    static void Main()
    {
        decimal moneyInUsd = decimal.Parse(Console.ReadLine());
        decimal exchangeRate = decimal.Parse(Console.ReadLine());
        decimal pizzaPriceInBgn = decimal.Parse(Console.ReadLine());
        decimal lasagnaPriceInBgn = decimal.Parse(Console.ReadLine());
        decimal sandwichPriceInBgn = decimal.Parse(Console.ReadLine());
        uint pizzaQuantity = uint.Parse(Console.ReadLine());
        uint lasagnaQuantity = uint.Parse(Console.ReadLine());
        uint sandwichQuantity = uint.Parse(Console.ReadLine());

        // convert prices to USD
        decimal pizzaPriceInUsd = pizzaPriceInBgn / exchangeRate;
        decimal lasagnaPriceInUsd = lasagnaPriceInBgn / exchangeRate;
        decimal sandwichPriceInUsd = sandwichPriceInBgn / exchangeRate;

        // total sum in USD
        decimal total = (pizzaPriceInUsd * (decimal)pizzaQuantity) + (lasagnaPriceInUsd * (decimal)lasagnaQuantity) + (sandwichPriceInUsd * (decimal)sandwichQuantity);

        if (moneyInUsd >= total)
        {
            Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", moneyInUsd - total);
        }
        else
        {
            Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", total - moneyInUsd);
        }
    }
}
