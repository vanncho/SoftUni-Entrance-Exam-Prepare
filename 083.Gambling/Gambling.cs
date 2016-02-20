using System;

class Program
{
    static void Main()
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        string[] housesHand = Console.ReadLine().Split();

        int housesStrength = 0;

        foreach (var card in housesHand)
        {
            switch (card)
            {
                case "J": housesStrength += 11; break;
                case "Q": housesStrength += 12; break;
                case "K": housesStrength += 13; break;
                case "A": housesStrength += 14; break;
                default: housesStrength += int.Parse(card);
                    break;
            }
        }

        int countWinning = 0;
        int totalHands = 0; // 13 ^ 4  - 13 на 4-то степен 
        // 2 до 15 са директно теглата на картите
        for (int card1 = 2; card1 < 15; card1++)
        {
            for (int card2 = 2; card2 < 15; card2++)
            {
                for (int card3 = 2; card3 < 15; card3++)
                {
                    for (int card4 = 2; card4 < 15; card4++)
                    {
                        int myPower = card1 + card2 + card3 + card4;

                        if (myPower > housesStrength)
                        {
                            countWinning++;
                        }
                        totalHands++;
                    }
                }
            }
        }

        decimal probability = (decimal)countWinning / totalHands;
        
        if (probability < 0.5M)
        {
            Console.WriteLine("FOLD");
        }
        else
        {
            Console.WriteLine("DRAW");
        }

        decimal expectedWinnings = probability * 2 * cash;
        Console.WriteLine("{0:0.00}", expectedWinnings);
    }
}
