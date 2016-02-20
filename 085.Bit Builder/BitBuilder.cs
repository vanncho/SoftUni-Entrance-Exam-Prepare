using System;
using System.Collections.Generic;
using System.Text;

class BitBuilder
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        List<int> bitsPositions = new List<int>();
        List<string> commands = new List<string>();

        while (true)
        {
            string bitPos = Console.ReadLine();

            if (bitPos == "quit")
            {
                break;
            }

            bitsPositions.Add(int.Parse(bitPos));

            string command = Console.ReadLine();
            commands.Add(command);
        }

        StringBuilder manipulate = new StringBuilder();
        string numberAsBits = Convert.ToString(number, 2).PadLeft(32, '0');
        manipulate.Append(numberAsBits);

        for (int i = 0; i < commands.Count; i++)
        {
            string currentCommand = commands[i];
            int pos = 31 - bitsPositions[i];

            switch (currentCommand)
            {
                case "flip":
                    if (manipulate[pos] == '0')
                    {
                        manipulate.Replace('0', '1', pos, 1);
                    }
                    else
                    {
                        manipulate.Replace('1', '0', pos, 1);
                    }
                    break;
                case "remove":
                    manipulate.Remove(pos, 1);
                    manipulate.Insert(0, '0');
                    break;
                case "insert":
                    manipulate.Remove(0, 1);
                    manipulate.Insert(pos, '1');
                    break;
            }
        }

        ulong result = Convert.ToUInt64(manipulate.ToString(), 2);
        Console.WriteLine(result);
    }
}
