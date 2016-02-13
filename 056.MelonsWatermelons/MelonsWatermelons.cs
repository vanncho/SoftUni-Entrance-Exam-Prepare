using System;

class MelonsWatermelons
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        int melons = 0;
        int watermelons = 0;
        int currentDay = s;

        for (int i = 1; i <= d; i++)
        {
            switch (currentDay)
            {
                case 1: watermelons++; break;
                case 2: melons += 2; break;
                case 3: melons++; watermelons++; break;
                case 4: watermelons += 2; break;
                case 5: melons += 2; watermelons += 2; break;
                case 6: melons += 2; watermelons++; break;
                case 7: melons += 0; watermelons += 0; break;
            }
            currentDay++;

            if (currentDay == 8)
            {
                currentDay = 1;
            }
        }

        if (melons < watermelons)
        {
            Console.WriteLine("{0} more watermelons", watermelons - melons);
        }
        if (melons > watermelons)
        {
            Console.WriteLine("{0} more melons", melons - watermelons);
        }
        if (melons == watermelons)
        {
            Console.WriteLine("Equal amount: {0}", melons);
        }
    }
}
