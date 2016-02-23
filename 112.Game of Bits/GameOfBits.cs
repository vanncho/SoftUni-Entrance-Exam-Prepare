using System;
using System.Text;

class GameOfBits
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        string numAsBits = Convert.ToString(number, 2).PadLeft(32, '0');
        int newNumber = 0;

        do
        {
            StringBuilder tempNum = new StringBuilder();

            if (command == "Odd")
            {
                for (int i = numAsBits.Length - 1; i >= 0; i-=2)
                {
                    tempNum.Insert(0, numAsBits[i]);
                }

                newNumber = Convert.ToInt32(tempNum.ToString(), 2);
                numAsBits = Convert.ToString(newNumber, 2).PadLeft(16, '0');
            }
            else
            {
                for (int i = numAsBits.Length - 2; i >= 0; i-=2)
                {
                    tempNum.Insert(0, numAsBits[i]);
                }

                newNumber = Convert.ToInt32(tempNum.ToString(), 2);
                numAsBits = Convert.ToString(newNumber, 2).PadLeft(16, '0');
            }

            command = Console.ReadLine();
        } while (command != "Game Over!");

        int count = 0;

        int start = numAsBits.IndexOf('1');

        for (int i = start - 1; i < numAsBits.Length; i++)
        {
            if (numAsBits[i] == '1')
            {
                count++;
            }
        }

        Console.WriteLine("{0} -> {1}", newNumber, count);
    }
}
