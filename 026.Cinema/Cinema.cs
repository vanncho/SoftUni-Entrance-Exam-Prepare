using System;

class Cinema
{
    static void Main()
    {
        string typeOfProjection = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        double sum = 0;
        double premierePrice = 12;
        double normalPrice = 7.5;
        double discountPrice = 5;

        if (typeOfProjection == "Premiere")
        {
            sum = rows * columns * premierePrice;
            Console.WriteLine("{0:0.00} leva", sum);
        }
        else if (typeOfProjection == "Normal")
        {
            sum = rows * columns * normalPrice;
            Console.WriteLine("{0:0.00} leva", sum);
        }
        else
        {
            sum = rows * columns * discountPrice;
            Console.WriteLine("{0:0.00} leva", sum);
        }
    }
}
