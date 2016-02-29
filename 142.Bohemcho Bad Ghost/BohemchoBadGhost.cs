using System;
using System.Linq;
using System.Text;

class BohemchoBadGhost
{
    static void Main()
    {
        char[] apartmentsAtFloor;
        string input = Console.ReadLine();
        int countOnes = 0;
        ulong finalScore = 0;

        do
        {
            uint floor = uint.Parse(input);
            int[] ordersToLigthUp = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string currentFloor = Convert.ToString(floor, 2).PadLeft(32, '0');
            apartmentsAtFloor = currentFloor.ToCharArray();

            for (int i = 0; i < ordersToLigthUp.Length; i++)
            {
                int currApt = 31 - ordersToLigthUp[i];

                if (apartmentsAtFloor[currApt] == '0')
                {
                    apartmentsAtFloor[currApt] = '1';
                }
                else
                {
                    apartmentsAtFloor[currApt] = '0';
                }
            }

            StringBuilder num = new StringBuilder();

            for (int i = 0; i < apartmentsAtFloor.Length; i++)
            {
                char currentChar = apartmentsAtFloor[i];
                if (currentChar == '1')
                {
                    countOnes++;
                }
                num.Append(currentChar);
            }

            uint res = Convert.ToUInt32(num.ToString(), 2);
            finalScore += res;

            input = Console.ReadLine();
        } while (input != "Stop, God damn it");

        Console.WriteLine("Bohemcho left {0} lights on and his score is {1}", countOnes, finalScore);
    }
}
