using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _153.Sudoku_Results
{
    class SudokuResults
    {
        static void Main(string[] args)
        {
            int gameCount = 0;
            int totalMinutes = 0;
            int totalSeconds = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Quit")
                {
                    break;
                }
                else
                {
                    string[] split = line.Split(':');

                    int minutes = int.Parse(split[0]);
                    int seconds = int.Parse(split[1]);

                    totalMinutes += minutes;
                    totalSeconds += seconds;
                    gameCount++;
                }
            }

            totalSeconds += (totalMinutes * 60);

            double score = Math.Ceiling((double)totalSeconds / (double)gameCount);
            string star = string.Empty;

            if (score < 720)
            {
                star = "Gold";
            }
            else if (score >= 720 && score <= 1440)
            {
                star = "Silver";
            }
            else
            {
                star = "Bronze";
            }

            Console.WriteLine("{0} Star", star);
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", gameCount, score);
        }
    }
}
