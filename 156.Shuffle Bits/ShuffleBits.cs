using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _156.Shuffle_Bits
{
    class ShuffleBits
    {
        static void Main(string[] args)
        {
            uint first = uint.Parse(Console.ReadLine());
            uint second = uint.Parse(Console.ReadLine());

            string firstToBits = Convert.ToString(first, 2).PadLeft(32, '0');
            string secondToBits = Convert.ToString(second, 2).PadLeft(32, '0');

            StringBuilder result = new StringBuilder();

            if (first >= second)
            {
                for (int i = 0; i < firstToBits.Length; i++)
                {
                    result.Append(firstToBits[i]);
                    result.Append(secondToBits[i]);
                }

                ulong newNumber = Convert.ToUInt64(result.ToString(), 2);
                Console.WriteLine(newNumber);
            }
            else
            {
                for (int i = 0; i < firstToBits.Length; i+=2)
                {
                    result.Append(firstToBits[i]);
                    result.Append(firstToBits[i + 1]);
                    result.Append(secondToBits[i]);
                    result.Append(secondToBits[i + 1]);
                }

                ulong newNumber = Convert.ToUInt64(result.ToString(), 2);
                Console.WriteLine(newNumber);
            }
        }
    }
}
