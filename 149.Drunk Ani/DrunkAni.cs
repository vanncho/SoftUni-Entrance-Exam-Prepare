using System;
using System.Numerics;

class DrunkAni
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint currentPosition = 0;
        uint futurePosition = 0;
        BigInteger totalStepsCount = 0;

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "Found a free one!")
            {
                break;
            }
            else
            {
                uint steps = uint.Parse(command);
                futurePosition = (steps + currentPosition) % n;

                if (futurePosition > currentPosition)
                {
                    totalStepsCount += (futurePosition - currentPosition);
                    Console.WriteLine("Go {0} steps to the right, Ani.", futurePosition - currentPosition);
                    currentPosition = futurePosition;
                }
                else if (futurePosition < currentPosition)
                {
                    totalStepsCount += currentPosition - futurePosition;
                    Console.WriteLine("Go {0} steps to the left, Ani.", currentPosition - futurePosition);
                    currentPosition = futurePosition;
                }
                else
                {
                    Console.WriteLine("Stay there, Ani.");
                }
            }
        }

        Console.WriteLine("Moved a total of {0} steps.", totalStepsCount);
    }
}
