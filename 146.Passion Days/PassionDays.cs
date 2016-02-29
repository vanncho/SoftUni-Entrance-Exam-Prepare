using System;

class PassionDays
{
    static void Main()
    {
        decimal money = decimal.Parse(Console.ReadLine());
        string line = Console.ReadLine();
        bool startShoping = false;
        int purchasesCount = 0;

        do
        {
            if (line == "mall.Enter")
            {
                startShoping = true;
            }
            else if (startShoping)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    char ch = line[i];
                    decimal purchasedSum = line[i];

                    if (char.IsLower(ch) && money > 0)
                    {
                        purchasedSum -= (purchasedSum * 0.70M);
                    }
                    else if (char.IsUpper(ch) && money > 0)
                    {
                        purchasedSum -= (purchasedSum * 0.50M);
                    }
                    else if (ch == '%' && money > 0)
	                {
	                	 purchasedSum = money / 2.0M;
	                }
                    else if (ch == '*')
	                {
                        money += 10M;
                        continue;
	                }

                    if (purchasedSum > money)
                    {
                        continue;
                    }
                    else
                    {
                        money -= purchasedSum;
                        purchasesCount++;
                    }
                }
            }

            line = Console.ReadLine();
        } while (line != "mall.Exit");

        if (purchasesCount == 0)
        {
            Console.WriteLine("No purchases. Money left: {0:f2} lv.", money);
        }
        else
        {
            Console.WriteLine("{0} purchases. Money left: {1:f2} lv.", purchasesCount, money);
        }
    }
}
