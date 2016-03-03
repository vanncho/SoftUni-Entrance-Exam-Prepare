using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _152.ProspHospitality
{
    class ProspectHospitality
    {
        static void Main(string[] args)
        {
            uint b = uint.Parse(Console.ReadLine());
            uint r = uint.Parse(Console.ReadLine());
            uint c = uint.Parse(Console.ReadLine());
            uint t = uint.Parse(Console.ReadLine());
            uint o = uint.Parse(Console.ReadLine());
            decimal nikiSalaryUSD = decimal.Parse(Console.ReadLine());
            decimal usdRate = decimal.Parse(Console.ReadLine());
            decimal s = decimal.Parse(Console.ReadLine());
            decimal m = decimal.Parse(Console.ReadLine());

            decimal nikiSalaryBGN = nikiSalaryUSD * usdRate;

            decimal allWorkersSalaries = ((decimal)b * 1500.04m) + ((decimal)r * 2102.10m) + ((decimal)c * 1465.46m) + ((decimal)t * 2053.33m) + ((decimal)o * 3010.98m) + nikiSalaryBGN + s;

            decimal budgetLeft = m - allWorkersSalaries;

            Console.WriteLine("The amount is: {0:f2} lv.", allWorkersSalaries);

            if (budgetLeft >= 0)
            {
                Console.WriteLine("YES \\ Left: {0:f2} lv.", budgetLeft);
            }
            else
            {
                Console.WriteLine("NO \\ Need more: {0:f2} lv.", Math.Abs(budgetLeft));
            }
        }
    }
}
