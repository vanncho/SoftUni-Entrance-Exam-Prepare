using System;

class PiggyBank
{
    static void Main()
    {
        int tankPrice = int.Parse(Console.ReadLine());
        int partyDays = int.Parse(Console.ReadLine());

        int normalDays = 30 - partyDays;
        int savesInNormalDays = normalDays * 2;
        int spendInPartyDays = 5 * partyDays;
        int totalSavesPerMonth = savesInNormalDays - spendInPartyDays;

        double totalMonths = (double)tankPrice / totalSavesPerMonth;
        int monthsNeededToSave = (int)Math.Ceiling(totalMonths);

        if (totalMonths < 0)
        {
            Console.WriteLine("never");
        }
        else
        {
            double yearsNeeded = monthsNeededToSave / 12;
            double months = monthsNeededToSave % 12;

            Console.WriteLine("{0} years, {1} months", (int)yearsNeeded, months);
        }

    }
}
