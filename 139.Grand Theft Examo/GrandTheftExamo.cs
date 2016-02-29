using System;

class GrandTheftExamo
{
    static void Main()
    {
        int escapeAttempts = int.Parse(Console.ReadLine());

        long totalSlaps = 0;
        long totalEscapes = 0;
        long totalBeers = 0;

        for (int i = 0; i < escapeAttempts; i++)
        {
            int thieves = int.Parse(Console.ReadLine());
            int beers = int.Parse(Console.ReadLine());

            int currentSlaps = 0;

            if (thieves < 5)
            {
                currentSlaps = thieves;
                totalEscapes += 0;
                totalSlaps += currentSlaps;
                totalBeers += beers;
            }
            else
            {
                currentSlaps = 5;
                int currentEscapes = thieves - 5;
                totalEscapes += currentEscapes;
                totalSlaps += currentSlaps;
                totalBeers += beers;
            }
        }

        long packs = 0;
        long botles = 0;

        packs = totalBeers / 6;
        botles = totalBeers % 6;

        Console.WriteLine("{0} thieves slapped.", totalSlaps);
        Console.WriteLine("{0} thieves escaped.", totalEscapes);
        Console.WriteLine("{0} packs, {1} bottles.", packs, botles);
    }
}
