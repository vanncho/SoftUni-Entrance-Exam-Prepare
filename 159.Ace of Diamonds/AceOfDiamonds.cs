using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _159.Ace_of_Diamonds
{
    class AceOfDiamonds
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // top
            Console.WriteLine("{0}", new string('*', n));
            int dashes = (n - 2) / 2;
            int symbol = 1;

            for (int i = 0; i <  (n - 2) / 2; i++)
            {
                Console.Write("*");
                Console.Write(new string('-', dashes));
                Console.Write(new string('@', symbol));
                Console.Write(new string('-', dashes));
                Console.WriteLine("*");
                dashes--;
                symbol+=2;
            }

            // middle
            Console.WriteLine("*{0}*", new string('@', n - 2));

            // bottom
            dashes = 1;
            symbol = n - 4;

            for (int i = 0; i < (n - 2) / 2; i++)
            {
                Console.Write("*");
                Console.Write(new string('-', dashes));
                Console.Write(new string('@', symbol));
                Console.Write(new string('-', dashes));
                Console.WriteLine("*");
                dashes++;
                symbol -= 2; ;
            }

            Console.WriteLine("{0}", new string('*', n));
        }
    }
}
