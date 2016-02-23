using System;

class DreamItem
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');

        string month = input[0];
        decimal moneyPerHour = decimal.Parse(input[1]);
        int hoursPerDay = int.Parse(input[2]);
        decimal priceOfItem = decimal.Parse(input[3]);

        int workingDays = 0;

        switch (month)
        {
            case "Jan": workingDays = 31 - 10; break;
            case "Feb": workingDays = 28 - 10; break;
            case "March": workingDays = 31 - 10; break;
            case "Apr": workingDays = 30 - 10; break;
            case "May": workingDays = 31 - 10; break;
            case "June": workingDays = 30 - 10; break; ;
            case "July": workingDays = 31 - 10; break;
            case "Aug": workingDays = 31 - 10; break;
            case "Sept": workingDays = 30 - 10; break;
            case "Oct": workingDays = 31 - 10; break;
            case "Nov": workingDays = 30 - 10; break;
            case "Dec": workingDays = 31 - 10; break;
        }

        decimal salary = (decimal)workingDays * moneyPerHour * (decimal)hoursPerDay;

        if (salary > 700)
        {
            salary += salary * (decimal)0.10;
        }

        if (salary < priceOfItem)
        {
            Console.WriteLine("Not enough money. {0:f2} leva needed.", priceOfItem - salary);
        }
        else
        {
            Console.WriteLine("Money left = {0:f2} leva.", salary - priceOfItem);
        }
    }
}
