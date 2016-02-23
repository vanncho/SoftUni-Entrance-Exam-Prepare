using System;

class TorrentPirate
{
    static void Main()
    {
        int dMegabytes = int.Parse(Console.ReadLine());
        int pMoneyCost= int.Parse(Console.ReadLine());
        int wWifeSpendPerHour = int.Parse(Console.ReadLine());

        double downloadTime = (double)dMegabytes / 2 / 60 / 60;
        double priceForDownload = downloadTime * wWifeSpendPerHour;

        double downloadedMovies = (double)dMegabytes / 1500;

        double cinemaPrice = downloadedMovies * pMoneyCost;

        if (priceForDownload > cinemaPrice)
        {
            Console.WriteLine("cinema -> {0:f2}lv", cinemaPrice);
        }
        if (priceForDownload <= cinemaPrice)
        {
            Console.WriteLine("mall -> {0:f2}lv", priceForDownload);
        }
    }
}
