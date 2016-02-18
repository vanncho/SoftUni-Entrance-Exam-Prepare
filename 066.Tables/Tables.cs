using System;

class Tables
{
    static void Main()
    {
        int bundle1 = int.Parse(Console.ReadLine());
        int bundle2 = int.Parse(Console.ReadLine());
        int bundle3 = int.Parse(Console.ReadLine());
        int bundle4 = int.Parse(Console.ReadLine());

        int tableTops = int.Parse(Console.ReadLine());
        int neededTables = int.Parse(Console.ReadLine());

        int availableLegs = (1 * bundle1) + (2 * bundle2) + (3 * bundle3) + (4 * bundle4);
        int legsForTables = availableLegs / 4;

        int legsNeeded = 0;
        int tableMade = 0;

        if (tableTops < neededTables)
        {
            if (tableTops < legsForTables)
            {
                tableMade = tableTops;
            }
            if (tableTops >= legsForTables)
            {
                tableMade = legsForTables;
            }
        }
        if (tableTops >= neededTables)
        {
            if (tableTops < legsForTables)
            {
                tableMade = tableTops;
            }
            if (tableTops >= legsForTables)
            {
                tableMade = legsForTables;
            }
        }


        if (tableMade < neededTables)
        {
            Console.WriteLine("less: {0}", tableMade - neededTables);
            int neededLegs = 0;
            if (availableLegs >= neededLegs)
            {
                neededLegs = 0;
            }
            else
            {
                neededLegs = Math.Abs(availableLegs - 4 * (neededTables));
            }
            Console.WriteLine("tops needed: {0}, legs needed: {1}", (neededTables - tableTops), neededLegs);
        }
        if (tableMade > neededTables)
        {
            Console.WriteLine("more: {0}", (tableTops - neededTables));
            Console.WriteLine("tops left: {0}, legs left: {1}", (tableTops - neededTables), (availableLegs - 4 * (neededTables)));
        }
        if (tableMade == neededTables)
        {
            Console.WriteLine("Just enough tables made: {0}", neededTables);
        }
    }
}
