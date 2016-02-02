using System;

class FruitMarket
{
    static void Main()
    {
        string dayOfWeek = Console.ReadLine();

        decimal totalPrice = 0M;
        bool isFruit = false;
        bool isVegetable = false;

        for (int i = 0; i < 3; i++)
        {
            decimal quantity = decimal.Parse(Console.ReadLine());
            string product = Console.ReadLine();

            if (product == "banana" || product == "orange" || product == "apple")
            {
                isFruit = true;
            }
            if (product == "cucumber" || product == "tomato")
            {
                isVegetable = true;
            }

            decimal price = 0M;
            switch (product)
	        {
                case "banana": price = 1.80M; break;
                case "cucumber": price = 2.75M; break;
                case "tomato": price = 3.20M; break;
                case "orange": price = 1.60M; break;
                case "apple": price = 0.86M; break;
	        }

            if (dayOfWeek == "Monday" || dayOfWeek == "Saturday")
            {
                totalPrice += (quantity * price);
            }
            else
            {
                if (dayOfWeek == "Tuesday")
                {
                    if (isFruit)
                    {
                        totalPrice += (quantity * price) * 0.8M;
                        isFruit = false;
                    }
                    else
                    {
                        totalPrice += (quantity * price);
                    }
                }

                if (dayOfWeek == "Wednesday")
                {
                    if (isVegetable)
                    {
                        totalPrice += (quantity * price) * 0.9M;
                        isVegetable = false;
                    }
                    else
                    {
                        totalPrice += (quantity * price);
                    }
                }

                if (dayOfWeek == "Thursday")
                {
                    if (product == "banana")
                    {
                       totalPrice += (quantity * price) * 0.7M; 
                    }
                    else
                    {
                        totalPrice += (quantity * price);
                    }
                }

                if (dayOfWeek == "Friday")
                {
                    totalPrice += (quantity * price) * 0.9M;
                }

                if (dayOfWeek == "Sunday")
                {
                    totalPrice += (quantity * price) * 0.95M;
                }
            }
        }
        Console.WriteLine("{0:0.00}", totalPrice);
    }
}
