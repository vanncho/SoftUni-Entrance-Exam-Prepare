using System;

class Illuminati
{
    static void Main()
    {
        string line = Console.ReadLine();

        // Listen very carefully, I shall say this only once.
        int vowelsCount = 0;
        int vowelsSum = 0;
        for (int i = 0; i < line.Length; i++)
        {
            string currentLetter = line[i].ToString().ToUpper();
            switch (currentLetter)
            {
                case "A": vowelsSum += 65; vowelsCount++; break;
                case "E": vowelsSum += 69; vowelsCount++; break;
                case "I": vowelsSum += 73; vowelsCount++; break;
                case "O": vowelsSum += 79; vowelsCount++; break;
                case "U": vowelsSum += 85; vowelsCount++; break;
            }
        }
        Console.WriteLine(vowelsCount);
        Console.WriteLine(vowelsSum);
    }
}