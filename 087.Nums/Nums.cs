using System;
using System.Collections.Generic;

class Nums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int number = n;
        List<int> range = new List<int>();

        for (int i = n; i <= m; i++)
        {
            range.Add(number);
            number++;
        }

        for (int i = 0; i < range.Count; i++)
        {
            if (range[i] % 2 == 0)
            {
                double res = Math.Sqrt(range[i]);
                Console.WriteLine("{0:f3}", res);
            }
            else
            {
                int res = range[i] * range[i];
                Console.WriteLine("{0:f3}", res);
            }
        }
    }
}
