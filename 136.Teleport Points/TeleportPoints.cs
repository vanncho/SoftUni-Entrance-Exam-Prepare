using System;
using System.Linq;

class TeleportPoints
{
    static void Main()
    {
        // Задачата дава 28 точи в juja-a

        double[] A = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double[] B = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double[] C = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double[] D = Console.ReadLine().Split().Select(double.Parse).ToArray();

        double ax = A[0];
        double ay = A[1];

        double bx = B[0];
        double by = B[1];

        double cx = C[0];
        double cy = C[1];

        double dx = D[0];
        double dy = D[1];

        double r = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double a = Math.Min(Math.Min(ay, by), Math.Min(cy, dy));
        double c = Math.Max(Math.Max(ay, by), Math.Max(cy, dy));
        double sideOne = Math.Abs(a) + Math.Abs(c);

        double b = Math.Min(Math.Min(ax, bx), Math.Min(cx, dx));
        double d = Math.Max(Math.Max(ax, bx), Math.Max(cx, dx));
        double sideTwo = Math.Abs(b) + Math.Abs(d);

        int count = 0;
        for (double i = ay; i < cy; i += h)
        {
            for (double j = ax; j < bx; j += h)
            {
                bool isPointInCircle = Math.Sqrt(i * i + j * j) <= r;
                bool isInsideTheRectangle = j > ax || j < bx || i > ay || i < cy;

                // circle is inside the rectangle
                if (r < (Math.Abs(ax) + Math.Abs(bx)) / 2 && r < (Math.Abs(ay) + Math.Abs(by) / 2))
                {
                    if (isPointInCircle)
                    {
                        count++;
                    }
                }

                //// rectangle is inside the circle
                //else if (r > (Math.Abs(ax) + Math.Abs(bx)) / 2 && r > (Math.Abs(ay) + Math.Abs(by) / 2))
                //{
                //    if (isInsideTheRectangle)
                //    {
                //        count++;
                //    }
                //}
                else if (isPointInCircle && isInsideTheRectangle)
                {
                    //if (r < (Math.Abs(ax) + Math.Abs(bx)) / 2)
                    //{
                    //    
                    //}
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}
