using System;

class BookProblem
{
    static void Main()
    {
        int bookPages = int.Parse(Console.ReadLine());
        int campingDays = int.Parse(Console.ReadLine());
        int pagesRead = int.Parse(Console.ReadLine());

        int daysToRead = 30 - campingDays;
        int readedInNormalDays = daysToRead * pagesRead;

        double totalMonths = Math.Ceiling((double)bookPages / (double)readedInNormalDays);
        int yearsNeeded = (int)totalMonths / 12;
        double monthsNeeded = totalMonths % 12;

        if (readedInNormalDays > 0)
        {
            Console.WriteLine("{0} years {1} months", yearsNeeded, monthsNeeded);
        }
        else
        {
            Console.WriteLine("never");
        }
    }
}
