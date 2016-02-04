using System;
class MagicDates
{
    static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());

        bool noMagicDate = true;

        for (int year = startYear; year <= endYear; year++)
        { 
            for (int month = 1; month <= 12; month++)
            {
                int dayEnd = 30;
                DateTime currentYear = new DateTime(year, 1, 1);
                bool isLeap = DateTime.IsLeapYear(currentYear.Year);
                if (month == 2)
                {
                    if (isLeap)
                    {
                        dayEnd -= 1;
                    }
                    else
                    {
                        dayEnd -= 2;
                    }  
                }
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    dayEnd += 1;
                }
                for (int day = 1; day <= dayEnd; day++)
                {
                    string d = day.ToString();
                    string m = month.ToString();

                    if (day.ToString().Length < 2)
                    {
                        d = "0" + day;
                    }

                    if (month.ToString().Length < 2)
                    {
                        m = "0" + month;
                    }
                    string date = "" + d + m + year;
                    int sum = 0;
                    for (int i = 0; i < date.Length; i++)
                    {
                        for (int j = i + 1; j <= date.Length; j++)
                        {
                            if (j == date.Length)
                            {
                                break;
                            }
                            sum += int.Parse(date[i].ToString()) * int.Parse(date[j].ToString());
                        }
                    }

                    if (sum == magicWeight)
                    {
                        Console.WriteLine("{0}-{1}-{2}", d, m, year);
                        noMagicDate = false;
                    }
                }
            }
        }

        if (noMagicDate)
        {
            Console.WriteLine("No");
        }
    }
}

