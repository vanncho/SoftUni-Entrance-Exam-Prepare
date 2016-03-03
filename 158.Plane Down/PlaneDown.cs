using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _158.Plane_Down
{
    class PlaneDown
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int planeNumbers = int.Parse(Console.ReadLine());

            for (int i = 0; i < planeNumbers; i++)
            {
                int planeX = int.Parse(Console.ReadLine());
                int planeY = int.Parse(Console.ReadLine());

                bool isInCircle = Math.Sqrt(planeX * planeX + planeY * planeY) <= r;

                if (isInCircle && planeX >= x - r && x <= x + 2 || planeY >= y - r && planeY <= y + 2)
                {
                    Console.WriteLine("You destroyed a plane at [{0},{1}]", planeX, planeY);
                }
            }
        }
    }
}
