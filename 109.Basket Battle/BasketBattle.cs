using System;

class BasketBattle
{
    static void Main()
    {
        string playerStart = Console.ReadLine();
        int rounds = int.Parse(Console.ReadLine());

        string secondPlayer = "";

        if (playerStart == "Simeon")
        {
            secondPlayer = "Nakov";
        }
        else
        {
            secondPlayer = "Simeon";
        }

        int firstPlayerPoints = 0;
        int secondPlayerPoints = 0;

        int roundCount = 1;
        int roundWon = 0;

        while (roundCount <= rounds)
        {
            int pointsToScore = int.Parse(Console.ReadLine());
            string succsessInfo = Console.ReadLine();

            if (succsessInfo == "success")
            {
                if (firstPlayerPoints + pointsToScore <= 500)
                {
                    firstPlayerPoints += pointsToScore;
                }
                roundWon = roundCount;
            }

            if (firstPlayerPoints >= 500 || secondPlayerPoints >= 500)
            {
                break;
            }

            pointsToScore = int.Parse(Console.ReadLine());
            succsessInfo = Console.ReadLine();

            if (succsessInfo == "success")
            {
                if (secondPlayerPoints + pointsToScore <= 500)
                {
                    secondPlayerPoints += pointsToScore;
                    roundWon = roundCount;
                }
            }

            if (firstPlayerPoints >= 500 || secondPlayerPoints >= 500)
            {
                break;
            }

            roundCount++;
            if (roundCount > rounds)
            {
                break;
            }
            // next round
            pointsToScore = int.Parse(Console.ReadLine());
            succsessInfo = Console.ReadLine();

            if (succsessInfo == "success")
            {
                if (secondPlayerPoints + pointsToScore <= 500)
                {
                    secondPlayerPoints += pointsToScore;
                    roundWon = roundCount;
                }
                roundWon = roundCount;
            }

            if (firstPlayerPoints >= 500 || secondPlayerPoints >= 500)
            {
                break;
            }

            pointsToScore = int.Parse(Console.ReadLine());
            succsessInfo = Console.ReadLine();

            if (succsessInfo == "success")
            {
                if (firstPlayerPoints + pointsToScore <= 500)
                {
                    firstPlayerPoints += pointsToScore;
                }
                roundWon = roundCount;
            }

            if (firstPlayerPoints >= 500 || secondPlayerPoints >= 500)
            {
                break;
            }
            roundCount++;
        }

        if (firstPlayerPoints < 500 && secondPlayerPoints < 500)
        {
            if (firstPlayerPoints > secondPlayerPoints)
            {
                Console.WriteLine(playerStart);
                Console.WriteLine(firstPlayerPoints - secondPlayerPoints);
            }
            if (secondPlayerPoints > firstPlayerPoints)
            {
                Console.WriteLine(secondPlayer);
                Console.WriteLine(secondPlayerPoints - firstPlayerPoints);
            }
            if (firstPlayerPoints == secondPlayerPoints)
            {
                Console.WriteLine("DRAW", playerStart);
                Console.WriteLine(firstPlayerPoints);
            }
        }

        if (firstPlayerPoints >= 500 || secondPlayerPoints >= 500)
        {
            if (firstPlayerPoints > secondPlayerPoints)
            {
                Console.WriteLine(playerStart);
                Console.WriteLine(roundWon);
                Console.WriteLine(firstPlayerPoints);
            }

            if (secondPlayerPoints > firstPlayerPoints)
            {
                Console.WriteLine(secondPlayer);
                Console.WriteLine(roundWon);
                Console.WriteLine(secondPlayerPoints);
            }
        }
    }
}
