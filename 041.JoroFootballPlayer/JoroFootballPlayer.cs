using System;

class JoroFootballPlayer
{
    static void Main()
    {
        string year = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int weekends = int.Parse(Console.ReadLine());

        double sumOfPlays = 0;
        double normalWeekendsPlays = (52 - weekends) * (2 / 3.0);
        int additionalPlays = 0;

        if (year == "t")
        {
            additionalPlays += 3;   
        }

        sumOfPlays += weekends + normalWeekendsPlays + (holidays * 0.5) + additionalPlays;

        Console.WriteLine((int)sumOfPlays);
    }
}
