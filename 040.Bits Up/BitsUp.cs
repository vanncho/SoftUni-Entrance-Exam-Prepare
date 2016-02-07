using System;
using System.Text;

class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        StringBuilder bits = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            string line = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0');
            bits.Append(line);
        }

        for (int i = 1; i < bits.Length; i += step)
        {
            if (bits[i] == '0')
            {
                bits.Replace('0', '1', i, 1);
            }
        }

        for (int i = 0; i < bits.Length; i+=8)
        {
            string temp = bits.ToString().Substring(i, 8);
            int num = Convert.ToInt32(temp, 2);
            Console.WriteLine(num);
        }
    }
}
