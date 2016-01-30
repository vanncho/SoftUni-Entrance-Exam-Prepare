using System;

class InsideTheBuilding
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] xCoordinates = new int[5];
        int[] yCoordinates = new int[5];

        for (int i = 0; i < 5; i++)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if ((x >= n && x <= 2 * n) && (y >= n && y < 4 * n) ||
                (x >= 0 && x <= 3 * n) && (y >= 0 && y <= n))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
