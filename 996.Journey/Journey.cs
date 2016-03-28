namespace _996.Journey
{
    using System;
    using System.Collections.Generic;

    public class Journey
    {
        public static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string[] destinations = {"Bulgaria", "Balkans", "Europe"};
            string destination = String.Empty;

            string[] places = {"Camp", "Hotel"};
            string place = String.Empty;

            decimal percent = 0m;
            decimal cost = 0m;

            if (budget <= 100)
            {
                destination = destinations[0];

                if (season == "summer")
                {
                    percent = 0.70m;
                    place = places[0];
                }
                else
                {
                    percent = 0.30m;
                    place = places[1];
                }

                cost = budget - (budget * percent);
            }
            else if (budget <= 1000)
            {
                destination = destinations[1];

                if (season == "summer")
                {
                    percent = 0.60m;
                    place = places[0];
                }
                else
                {
                    percent = 0.20m;
                    place = places[1];
                }

                cost = budget - (budget * percent);
            }
            else
            {
                destination = destinations[2];
                place = places[1];
                percent = 0.10m;
                cost = budget - (budget * percent);
            }

            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine("{0} - {1:0.00}", place, cost);
        }
    }
}
