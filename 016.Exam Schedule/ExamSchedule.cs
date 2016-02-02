using System;
using System.Globalization;
using System.Threading;

class ExamSchedule
{
    static void Main()
    {
        //Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

        int hour = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        string partOfTheDay = Console.ReadLine();

        int durationHours = int.Parse(Console.ReadLine());
        int durationMinutes = int.Parse(Console.ReadLine());

        hour += durationHours;
        minutes += durationMinutes;

        while (minutes >= 60)
        {
            minutes -= 60;
            hour++;
        }

        if (hour >= 12)
        {
            int changePartOfDay = 0;
            while (hour >= 12)
            {
                hour -= 12;
                changePartOfDay++;
            }

            if (hour == 0)
            {
                hour += 12;
            }

            if (changePartOfDay % 2 != 0)
            {
                if (partOfTheDay == "AM") partOfTheDay = "PM";
                else
                {
                    partOfTheDay = "AM";
                }
            }
        }

        Console.WriteLine(hour.ToString().PadLeft(2, '0')+':'
            +minutes.ToString().PadLeft(2,'0')+':'+partOfTheDay);

        ////With DateTime
        //if (partOfTheDay == "PM")
        //{
        //    hour += 12;
        //    if (hour == 24)
        //    {
        //        hour = 0;
        //    }
        //}
        //
        //DateTime startTime = new DateTime(2016, 01, 01, hour, minutes, 0);
        //DateTime endTime = startTime.AddHours(durationHours).AddMinutes(durationMinutes);
        //Console.WriteLine("{0:hh:mm:tt}", endTime);
    }
}
