using System;

class FourFactors
{
    static void Main()
    {
        long FG = long.Parse(Console.ReadLine());
        long FGA = long.Parse(Console.ReadLine());
        long threeP = long.Parse(Console.ReadLine());
        long TOV = long.Parse(Console.ReadLine());
        long ORB = long.Parse(Console.ReadLine());
        long oppDRB = long.Parse(Console.ReadLine());
        long FT = long.Parse(Console.ReadLine());
        long FTA = long.Parse(Console.ReadLine());

        double eFGpercent = (FG + (0.5 * threeP)) / FGA;
        double TOVpercent = TOV / (FGA + (0.44 * FTA) + TOV);
        double ORBpercent = (double)ORB / (ORB + oppDRB);
        double FTpercent = (double)FT / FGA;

        Console.WriteLine("eFG% {0:f3}", eFGpercent);
        Console.WriteLine("TOV% {0:f3}", TOVpercent);
        Console.WriteLine("ORB% {0:f3}", ORBpercent);
        Console.WriteLine("FT% {0:f3}", FTpercent);
    }
}