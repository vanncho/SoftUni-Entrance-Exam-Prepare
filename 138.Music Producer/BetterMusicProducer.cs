using System;

class BetterMusicProducer
{
    static void Main()
    {
        int albInEurope = int.Parse(Console.ReadLine());
        decimal albPriceFromEuro = decimal.Parse(Console.ReadLine()) * 1.94M;

        int albInNAmerica = int.Parse(Console.ReadLine());
        decimal albPriceFromDollars = decimal.Parse(Console.ReadLine()) * 1.72M;

        int albInSAmerica = int.Parse(Console.ReadLine());
        decimal albPriceFromPesos = decimal.Parse(Console.ReadLine()) / 332.74M;

        int numberOfConcerts = int.Parse(Console.ReadLine());
        decimal profitPerConcertFromEuro = decimal.Parse(Console.ReadLine()) * 1.94M;

        // incomes from albums
        decimal albumsIncomeFromEurope = (decimal)albInEurope * albPriceFromEuro;
        decimal albumsIncomeNAmerica = (decimal)albInNAmerica * albPriceFromDollars;
        decimal albumsIncomeFromSAmerica = (decimal)albInSAmerica * albPriceFromPesos;

        decimal totalIncomesFromAlbums = (albumsIncomeFromEurope + albumsIncomeNAmerica + albumsIncomeFromSAmerica);
        decimal IncomesAfterProducer = totalIncomesFromAlbums - (totalIncomesFromAlbums * 0.35M);
        decimal IncomesAfterTaxes = IncomesAfterProducer - (IncomesAfterProducer * 0.20M);

        // incomes from concerts
        decimal incomesFromConcerts = (decimal)numberOfConcerts * profitPerConcertFromEuro;

        if (incomesFromConcerts > 100000)
        {
            incomesFromConcerts = incomesFromConcerts - (incomesFromConcerts * 0.15M);
        }

        if (IncomesAfterTaxes > incomesFromConcerts)
        {
            Console.WriteLine("Let's record some songs! They'll bring us {0:f2}lv.", IncomesAfterTaxes);
        }
        else
        {
            Console.WriteLine("On the road again! We'll see the world and earn {0:f2}lv.", incomesFromConcerts);
        }
    }
}
