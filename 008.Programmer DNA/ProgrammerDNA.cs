using System;

class ProgrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());

        int diff = 0;
        int width = 7;
        int middle = width / 2;

        for (int rows = 0; rows < n; rows++)
        {
            for (int i = 0; i < width; i++)
            {
                if ((i >= middle - diff) && (i <= middle + diff))
                {
                    Console.Write(letter);

                    if (letter == 'G')
                    {
                        letter = 'A';
                    }
                    else
                    {
                        letter++;
                    }
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();

            if ((rows % width) >= middle)
            {
                diff--;
                if ((rows % width == 6))
                {
                    diff++;
                }
            }
            else
            {
                diff++;
            }
        }
    }
}
