using System;
using System.Text;

class BitsInverter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        StringBuilder bits = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            string currentLineBits = Convert.ToString(num, 2).PadLeft(8, '0');
            bits.Append(currentLineBits);
        }

        for (int i = 0; i < bits.Length; i+=step)
        {
            char currentDigit = bits[i];

            if (currentDigit == '0')
            {
                bits.Replace('0', '1', i, 1);
            }
            else
            {
                bits.Replace('1', '0', i, 1);
            }
        }

        for (int i = 0; i < bits.Length; i+=8)
        {
            string current = bits.ToString().Substring(i, 8);
            int num = Convert.ToInt32(current, 2);
            Console.WriteLine(num);
        }
    }
}
