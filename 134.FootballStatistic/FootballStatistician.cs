using System;

class FootballStatistician
{
    static void Main()
    {
        string[] teams = { "Arsenal", "Chelsea", "Everton", "Liverpool", "ManchesterCity", "ManchesterUnited", "Southampton", "Tottenham" };
        int[] points = new int [8];

        decimal payment = decimal.Parse(Console.ReadLine());
        int matchesCount = 0;

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "End of the league.")
            {
                break;
            }
            else
            {
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string teamOne = split[0];
                string teamTwo = split[2];
                string result = split[1];

                int indexOfTeamOne = Array.IndexOf(teams, teamOne);
                int indexoOfTeamTwo = Array.IndexOf(teams, teamTwo);

                switch (result)
                {
                    case "1": points[indexOfTeamOne] += 3; break;
                    case "X": points[indexOfTeamOne] += 1; points[indexoOfTeamTwo] += 1; break;
                    case "2": points[indexoOfTeamTwo] += 3; break;
                }

                matchesCount++;
            }
        }

        decimal moneyInBGN = ((decimal)matchesCount * payment) * 1.94M;

        Console.WriteLine("{0:f2}lv.", moneyInBGN);
        for (int i = 0; i < teams.Length; i++)
        {
            if (teams[i] == "ManchesterCity")
            {
                teams[i] = "Manchester City";
            }
            else if (teams[i] == "ManchesterUnited")
	        {
                teams[i] = "Manchester United";
	        }
            Console.WriteLine("{0} - {1} points.", teams[i], points[i]);
        }
    }
}
