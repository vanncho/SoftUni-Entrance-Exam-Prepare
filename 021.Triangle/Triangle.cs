using System;

class Triangle
{
    static void Main()
    {
        int ax = int.Parse(Console.ReadLine());
        int ay = int.Parse(Console.ReadLine());

        int bx = int.Parse(Console.ReadLine());
        int by = int.Parse(Console.ReadLine());

        int cx = int.Parse(Console.ReadLine());
        int cy = int.Parse(Console.ReadLine());

        double distanceA = Math.Sqrt(Math.Pow((cx - bx), 2) + Math.Pow((cy - by), 2));
        double distanceB = Math.Sqrt(Math.Pow((cx - ax), 2) + Math.Pow((cy - ay), 2));
        double distanceC = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2));

        double perimeter = (distanceA + distanceB + distanceC) / 2;
        double area = Math.Sqrt(perimeter * (perimeter - distanceA) * (perimeter - distanceB) * (perimeter - distanceC));

        if (distanceA + distanceB > distanceC && distanceB + distanceC > distanceA && distanceA + distanceC > distanceB)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("{0:0.00}", area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:0.00}", distanceA);
        } 
    }
}
