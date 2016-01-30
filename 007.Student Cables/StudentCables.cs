using System;
class StudentCables
{
    static void Main()
    {
        int numberOfCables = int.Parse(Console.ReadLine());

        int sumOfCables = 0;
        int count = 0;

        for (int i = 0; i < numberOfCables; i++)
        {
            int cableLength = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();

            if (measure == "meters")
            {
                cableLength *= 100;
            }

            if (cableLength >= 20)
            {
                sumOfCables += cableLength;
                count++;
            }
        }

        int restOfCable = sumOfCables - ((count - 1) * 3);
        int cablesCanConnect = restOfCable / 504;
        int totalCableLength = cablesCanConnect * 504;
        int rest = restOfCable - totalCableLength;


        Console.WriteLine(cablesCanConnect);
        Console.WriteLine(rest);
    }
}