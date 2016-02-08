using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger a = int.Parse(Console.ReadLine());
        BigInteger b = int.Parse(Console.ReadLine());
        BigInteger c = int.Parse(Console.ReadLine());
        int nth = int.Parse(Console.ReadLine());

        BigInteger next = 0;
        long index = 3;

        while (index <= nth)
        {
            next = a + b + c;
            index++;
            a = b;
            b = c;
            c = next;
        }

        Console.WriteLine(b);
    }
}
