using System;

class BaiIvanAdventures
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        decimal moneyHeHas = decimal.Parse(Console.ReadLine());
        decimal litersWantToDrink = decimal.Parse(Console.ReadLine());

        decimal priceOfThatDay = 0M;

        switch (day)
        {
            case 0: priceOfThatDay = 25.0M; break;
            case 1: priceOfThatDay = 21.0M; break;
            case 2: priceOfThatDay = 14.0M; break;
            case 3: priceOfThatDay = 17.0M; break;
            case 4: priceOfThatDay = 45.0M; break;
            case 5: priceOfThatDay = 59.0M; break;
            case 6: priceOfThatDay = 42.0M; break;
        }

        decimal litesCanBuy = moneyHeHas / priceOfThatDay;
        string condition = "";

        if (litesCanBuy < 1.0M)
        {
            condition = "sober";
        }
        else if (litesCanBuy >= 1.0M && litesCanBuy <= 1.5M)
        {
            condition = "drunk";
        }
        else
        {
            condition = "very drunk";
        }

        if (litesCanBuy >= litersWantToDrink)
        {
            if (litesCanBuy == litersWantToDrink)
            {
                Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted", condition);
            }
            else
            {
                Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:f2} l. of alcohol with his friends", condition, Math.Abs(litersWantToDrink - litesCanBuy));
            }
            
        }
        else
        {
            Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:f2} l. of alcohol", condition, Math.Abs(litesCanBuy - litersWantToDrink));
        }      
    }
}
