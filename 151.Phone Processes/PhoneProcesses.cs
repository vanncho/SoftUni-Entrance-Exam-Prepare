using System;
using System.Collections.Generic;

class PhoneProcesses
{
    static void Main()
    {
        string[] readBattery = Console.ReadLine().Split('%');
        int batteryPercents = int.Parse(readBattery[0]);

        int applicationsCount = 0;
        int applicationsLeft = 0;

        while (true)
        {
            string readLine = Console.ReadLine();

            if (readLine.ToLower() == "end")
            {
                break;
            }
            else
            {
                string[] splitted = readLine.Split(new char[] {'_', '%'},StringSplitOptions.RemoveEmptyEntries);
                int currAppUsage = int.Parse(splitted[1]);

                if (batteryPercents > 15)
                {
                    batteryPercents -= currAppUsage;
                    applicationsCount++;
                }
                else
                {
                    applicationsLeft++;
                }
            }
        }

        if (batteryPercents <= 0)
        {
            Console.WriteLine("Phone Off");
        }
        else if (batteryPercents <= 15)
        {
            Console.WriteLine("Connect charger -> {0}%", batteryPercents);
            Console.WriteLine("Programs left -> {0}", applicationsLeft);
        }
        else
        {
            Console.WriteLine("Successful complete -> {0}%", batteryPercents);
        }
    }
}