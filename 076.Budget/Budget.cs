using System;

class Budget
{
    static void Main()
    {
        int nMoney = int.Parse(Console.ReadLine());
        int pWeekdays = int.Parse(Console.ReadLine());
        int hHometown = int.Parse(Console.ReadLine());

        int normalWeekends = 4 - hHometown;
        int expenceInWeekend = (normalWeekends * 2) * 20;
        int weekDaysGoOut = pWeekdays * (int)((nMoney - (nMoney * 0.97)) + 10);
        int normalWeekDays = 22 - pWeekdays;
        int expenceNormalWeekdays = normalWeekDays * 10;

        int totalExpence = expenceInWeekend + weekDaysGoOut + expenceNormalWeekdays + 150;

        if (totalExpence < nMoney)
        {
            Console.WriteLine("Yes, leftover {0}.", nMoney - totalExpence);
        }
        if (totalExpence > nMoney)
        {
            Console.WriteLine("No, not enough {0}.", totalExpence - nMoney);
        }
        if (totalExpence == nMoney)
        {
            Console.WriteLine("Exact Budget.");
        }
    }
}
