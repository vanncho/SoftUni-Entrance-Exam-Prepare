using System;
using System.Collections.Generic;

class CountBeers
{
    static void Main()
    {
        List<int> count = new List<int>();
        List<string> measure = new List<string>();

        while (true)
        {
            string input = Console.ReadLine();
            string[] line = input.Split();
            if (input == "End")
            {
                break;
            }

            count.Add(int.Parse(line[0]));
            measure.Add(line[1]);
        }

        int totalBeers = 0;

        for (int i = 0; i < count.Count; i++)
        {
            if (measure[i] == "stacks")
            {
                totalBeers += (20 * count[i]);
            }
            else
            {
                totalBeers += count[i];
            }
        }

        int stacks = totalBeers / 20;
        int beers = totalBeers % 20;

        Console.WriteLine("{0} stacks + {1} beers", stacks, beers);
    }
}
