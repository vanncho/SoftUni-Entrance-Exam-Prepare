using System;

class Volleyball
{
    static void Main()
    {
        int totalWeekends = 48;

        string year = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int weekends = int.Parse(Console.ReadLine());

        double sumOfPlays = 0; 
        int normalWeekends = totalWeekends - weekends;

        sumOfPlays += weekends + (normalWeekends * (3.0 / 4)) + (holidays * (2.0 / 3));

        if (year == "leap")
        {
            sumOfPlays += (sumOfPlays * 0.15);
            Console.WriteLine((int)sumOfPlays);
        }
        else
        {
            Console.WriteLine((int)sumOfPlays);
        }

    }
}
