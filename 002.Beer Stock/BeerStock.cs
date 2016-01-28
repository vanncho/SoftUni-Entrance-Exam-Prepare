using System;
using System.Collections.Generic;
class BeerStock
{
    static void Main()
    {
        long reservedBeers = long.Parse(Console.ReadLine());
        List<long> beersVariety = new List<long>();
        List<string> beersPacks = new List<string>();

        while (true)
        {
            string[] line = Console.ReadLine().Split(new char [] {' '}, StringSplitOptions.RemoveEmptyEntries);

            if (line[0] == "Exam")
            {
                break;
            }
            beersVariety.Add(long.Parse(line[0]));
            beersPacks.Add(line[1]);
        }

        long sumOfBeers = SumOfBeers(beersVariety, beersPacks);
        long sumOfBeersNeeded = 0;

        long beersNeeded = 0;
        long sixpacksNeeded = 0;
        long casesNeeded = 0;
        long beersAvailable = 0;

        if (sumOfBeers > 99)
        {
            sumOfBeers = sumOfBeers - (sumOfBeers / 100);
        }

        if (sumOfBeers >= reservedBeers)
        {
            beersAvailable = sumOfBeers - reservedBeers;

            beersNeeded = beersAvailable % 24;
            casesNeeded = beersAvailable / 24;

            if (beersNeeded >= 6)
            {
                sixpacksNeeded = beersNeeded / 6;
                beersNeeded = beersNeeded % 6;
            }

            Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", casesNeeded, sixpacksNeeded, beersNeeded);
        }
        else
        {
            beersAvailable = sumOfBeers - reservedBeers;

            if (beersAvailable < 0)
            {
                beersAvailable *= -1;
            }

            beersNeeded = beersAvailable % 24;
            casesNeeded = beersAvailable / 24;

            if (beersNeeded >= 6)
            {
                sixpacksNeeded = beersNeeded / 6;
                beersNeeded = beersNeeded % 6;
            }

            Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", casesNeeded, sixpacksNeeded, beersNeeded);
        }

    }

    private static long SumOfBeers(List<long> beersVariety, List<string> beersPacks)
    {
        long sumOfBeers = 0;

        for (int i = 0; i < beersVariety.Count; i++)
        {
            if (beersPacks[i] == "sixpacks")
            {
                beersVariety[i] = beersVariety[i] * 6;
            }
            if (beersPacks[i] == "cases")
            {
                beersVariety[i] = beersVariety[i] * 24;
            }

            sumOfBeers += beersVariety[i];
        }
        return sumOfBeers;
    }
}

