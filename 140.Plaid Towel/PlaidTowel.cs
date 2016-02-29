using System;

class PlaidTowel
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char background = char.Parse(Console.ReadLine());
        char rhombus = char.Parse(Console.ReadLine());

        int outerDots = size;
        int dotsInRombus = 2 * size - 1;
        int middleDots = 2 * size - 1;

        Console.WriteLine("{0}{2}{1}{2}{0}", new string(background, outerDots), new string(background, dotsInRombus), rhombus);

        outerDots--;
        dotsInRombus = 1;
        middleDots -= 2;

        for (int i = 0; i < size - 1; i++)
        {
            Console.Write(new string(background, outerDots));
            Console.Write(rhombus);
            Console.Write(new string(background, dotsInRombus));
            Console.Write(rhombus);
            Console.Write(new string(background, middleDots));
            Console.Write(rhombus);
            Console.Write(new string(background, dotsInRombus));
            Console.Write(rhombus);
            Console.WriteLine(new string(background, outerDots));
            outerDots--;
            dotsInRombus += 2;
            middleDots -= 2;
        }

        Console.WriteLine("{0}{1}{0}{1}{0}", rhombus, new string(background, 2 * size - 1));

        outerDots = 1;
        dotsInRombus -= 2;
        middleDots += 2;

        for (int i = 0; i < size - 1; i++)
        {
            Console.Write(new string(background, outerDots));
            Console.Write(rhombus);
            Console.Write(new string(background, dotsInRombus));
            Console.Write(rhombus);
            Console.Write(new string(background, middleDots));
            Console.Write(rhombus);
            Console.Write(new string(background, dotsInRombus));
            Console.Write(rhombus);
            Console.WriteLine(new string(background, outerDots));
            outerDots++;
            dotsInRombus -= 2;
            middleDots += 2;
        }

        // middle
        outerDots = size;
        dotsInRombus = 2 * size - 1;
        middleDots = 2 * size - 1;
        Console.WriteLine("{0}{2}{1}{2}{0}", new string(background, outerDots), new string(background, dotsInRombus), rhombus);

        outerDots--;
        dotsInRombus = 1;
        middleDots -= 2;

        for (int i = 0; i < size - 1; i++)
        {
            Console.Write(new string(background, outerDots));
            Console.Write(rhombus);
            Console.Write(new string(background, dotsInRombus));
            Console.Write(rhombus);
            Console.Write(new string(background, middleDots));
            Console.Write(rhombus);
            Console.Write(new string(background, dotsInRombus));
            Console.Write(rhombus);
            Console.WriteLine(new string(background, outerDots));
            outerDots--;
            dotsInRombus += 2;
            middleDots -= 2;
        }

        Console.WriteLine("{0}{1}{0}{1}{0}", rhombus, new string(background, 2 * size - 1));

        outerDots = 1;
        dotsInRombus -= 2;
        middleDots += 2;

        for (int i = 0; i < size - 1; i++)
        {
            Console.Write(new string(background, outerDots));
            Console.Write(rhombus);
            Console.Write(new string(background, dotsInRombus));
            Console.Write(rhombus);
            Console.Write(new string(background, middleDots));
            Console.Write(rhombus);
            Console.Write(new string(background, dotsInRombus));
            Console.Write(rhombus);
            Console.WriteLine(new string(background, outerDots));
            outerDots++;
            dotsInRombus -= 2;
            middleDots += 2;
        }

        outerDots = size;
        dotsInRombus = 2 * size - 1;
        middleDots = 2 * size - 1;
        Console.WriteLine("{0}{2}{1}{2}{0}", new string(background, outerDots), new string(background, dotsInRombus), rhombus);
    }
}
