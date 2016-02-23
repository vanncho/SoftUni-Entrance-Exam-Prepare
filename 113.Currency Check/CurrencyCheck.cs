using System;

class CurrencyCheck
{
    static void Main()
    {
        uint rubles = uint.Parse(Console.ReadLine());
        uint dollars = uint.Parse(Console.ReadLine());
        uint euro = uint.Parse(Console.ReadLine());
        uint levaB = uint.Parse(Console.ReadLine());
        uint levaM = uint.Parse(Console.ReadLine());

        // currency in BGN
        decimal oneRuble = 0.035M;
        decimal oneDollar = 1.5M;
        decimal oneEuro = 1.95M;

        // prices from different sites in BGN
        decimal fromRubles = (decimal)rubles * oneRuble;
        decimal fromDollars = (decimal)dollars * oneDollar;
        decimal fromEuros = (decimal)euro * oneEuro;

        decimal priceForOneCopyOfB = (decimal)levaB / 2;

        decimal min = Math.Min(Math.Min(fromRubles, fromDollars), Math.Min(fromEuros, priceForOneCopyOfB));

        Console.WriteLine("{0:f2}", min);
    }
}
