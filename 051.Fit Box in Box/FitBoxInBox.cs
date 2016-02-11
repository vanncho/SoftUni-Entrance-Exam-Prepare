﻿using System;
using System.Collections.Generic;

class FitBoxInBox
{
    static void Main()
    {
        int w1 = int.Parse(Console.ReadLine());
        int h1 = int.Parse(Console.ReadLine());
        int d1 = int.Parse(Console.ReadLine());

        int w2 = int.Parse(Console.ReadLine());
        int h2 = int.Parse(Console.ReadLine());
        int d2 = int.Parse(Console.ReadLine());

        // if first box is smaller
        CheckSizesOfTheBox(w1, h1, d1, w2, h2, d2);
        CheckSizesOfTheBox(w1, h1, d1, w2, d2, h2);
        CheckSizesOfTheBox(w1, h1, d1, h2, w2, d2);
        CheckSizesOfTheBox(w1, h1, d1, h2, d2, w2);
        CheckSizesOfTheBox(w1, h1, d1, d2, w2, h2);
        CheckSizesOfTheBox(w1, h1, d1, d2, h2, w2);

        // if second box is smaller
        CheckSizesOfTheBox(w2, h2, d2, w1, h1, d1);
        CheckSizesOfTheBox(w2, h2, d2, w1, d1, h1);
        CheckSizesOfTheBox(w2, h2, d2, h1, w1, d1);
        CheckSizesOfTheBox(w2, h2, d2, h1, d1, w1);
        CheckSizesOfTheBox(w2, h2, d2, d1, w1, h1);
        CheckSizesOfTheBox(w2, h2, d2, d1, h1, w1);

    }

    static void CheckSizesOfTheBox(int w1, int h1, int d1, int w2, int h2, int d2)
    {
        if ((w1 < w2) &&
            (h1 < h2) &&
            (d1 < d2))
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, w2, h2, d2);
        }
    }
}
