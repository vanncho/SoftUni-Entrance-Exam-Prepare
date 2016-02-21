using System;

class Headphones
{
    static void Main()
    {
        int diameter = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('-', diameter / 2), new string('*', diameter + 2));
        for (int i = 0; i < diameter - 1; i++)
        {
            Console.Write(new string('-', diameter / 2));
            Console.Write("*");
            Console.Write(new string('-', diameter));
            Console.Write("*");
            Console.WriteLine(new string('-', diameter / 2));
        }

        int outerDashes = diameter / 2;
        int innerDashes = diameter;
        int asterisks = 1;

        for (int i = 0; i < diameter; i++)
        {
            Console.Write(new string('-', outerDashes));
            Console.Write(new string('*', asterisks));
            Console.Write(new string('-', innerDashes));
            Console.Write(new string('*', asterisks));
            Console.Write(new string('-', outerDashes));

            if (i < diameter / 2)
            {
                outerDashes--;
                asterisks += 2;
                innerDashes -= 2;
            }
            else
            {
                outerDashes++;
                asterisks -= 2;
                innerDashes += 2;
            }

            Console.WriteLine();
        }

    }
}
