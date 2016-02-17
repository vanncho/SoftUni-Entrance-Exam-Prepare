using System;
using System.Linq;

class Electricity
{
    static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        int[] time = Console.ReadLine().Split(new char[] {':'}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        double computerConsuming = 125.90;
        double lampConsuming = 100.53;

        int lamps = 0;
        int computers = 0;

        if (time[0] >= 14 && time[0] <= 18)
        {
            lamps = 2;
            computers = 2;
        }
        if (time[0] >= 19 && time[0] <= 23)
        {
            lamps = 7;
            computers = 6;
        }
        if (time[0] >= 0 && time[0] <= 8)
        {
            lamps = 1;
            computers = 8;
        }

        double oneFlatConsumation = (lamps * lampConsuming) + (computers * computerConsuming);
        int allFlats = floors * flats;

        double res = oneFlatConsumation * allFlats;
        Console.WriteLine("{0} Watts", (int)res);
    }
}
