using System;
using System.Collections.Generic;
using System.Text;

class MasterHerbalist
{
    static void Main()
    {
        int dailyExpenses = int.Parse(Console.ReadLine());

        List<int> hours = new List<int>(); // !!! May Be Array ?
        List<string> path = new List<string>();
        List<int> price = new List<int>();

        while (true)
        {
            string[] currentLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (currentLine[0] != "Season")
            {
                hours.Add(int.Parse(currentLine[0]));
                path.Add(currentLine[1]);
                price.Add(int.Parse(currentLine[2]));
            }
            else
            {
                break;
            }
        }

        var herbsPerPath = CollectedHerbsPerPath(hours, path);
        int totalMoneyMade = SumOfMoneyPerPath(herbsPerPath, price);

        double averageEarningsPerDay = (double)totalMoneyMade / herbsPerPath.Length;
        double difference = 0;

        if (averageEarningsPerDay >= dailyExpenses)
        {
            difference = averageEarningsPerDay - dailyExpenses;
            Console.WriteLine("Times are good. Extra money per day: {0:0.00}.", difference);
        }
        else
        {
            int moneyNeeded = (dailyExpenses * herbsPerPath.Length) - totalMoneyMade;
            Console.WriteLine("We are in the red. Money needed: {0}.", moneyNeeded);
        }

    }

    static int SumOfMoneyPerPath(int[] herbsPerPath, List<int> price)
    {
        int sumOfMoney = 0;

        for (int i = 0; i < herbsPerPath.Length; i++)
        {
            sumOfMoney += herbsPerPath[i] * price[i];
        }

        return sumOfMoney;
    }

    static int[] CollectedHerbsPerPath(List<int> hours, List<string> path)
    {
        var herbsPerPath = new int[path.Count];

        for (int i = 0; i < path.Count; i++)
        {
            int count = 0;
            string currentPath = path[i];
            for (int j = 0; j < hours[i]; j++)
            {
                int index = j % path[i].Length;
                if (currentPath[index].ToString() == "H")
                {
                    count++;
                    herbsPerPath[i] = count;
                }
            }
        }

        return herbsPerPath;
    }
}
