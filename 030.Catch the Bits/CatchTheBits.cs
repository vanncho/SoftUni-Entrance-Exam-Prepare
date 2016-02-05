using System;
using System.Text;
using System.Numerics;

class CatchTheBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        StringBuilder bits = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            string b = Convert.ToString(number, 2);

            if (number == 0)
            {
                bits.Insert(bits.Length, "0", 7);
            }
            else if (b.Length < 8)
            {
                bits.Insert(bits.Length, "0", (8 - b.Length));
            }
            bits.Append(b);
        }

        StringBuilder newNumber = new StringBuilder();

        for (int i = 1; i < bits.Length; i += step)
        {
            newNumber.Append(bits[i]);
        }

        while (newNumber.Length % 8 != 0)
        {
            newNumber.Insert(newNumber.Length, "0", Math.Abs(8 - (newNumber.Length)));
        }

        for (int i = 0; i < newNumber.Length; i += 8)
        {
            string number = newNumber.ToString().Substring(i, 8);
            int num = Convert.ToInt32(number, 2);
            Console.WriteLine(num);
        }
    }
}