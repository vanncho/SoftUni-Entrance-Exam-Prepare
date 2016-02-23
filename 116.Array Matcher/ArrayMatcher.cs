using System;
using System.Collections.Generic;
using System.Text;

class ArrayMatcher
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');

        List<int> first = FillArrayWithNumbers(input[0]);
        List<int> second = FillArrayWithNumbers(input[1]);
        string command = input[2];

        List<int> join = new List<int>();

        switch (command)
        {
            case "join":

                for (int i = 0; i < first.Count; i++)
                {
                    for (int j = 0; j < second.Count; j++)
                    {
                        if (first[i] == second[j])
                        {
                            Console.Write(Convert.ToChar(first[i]));
                        }
                    }
                }
                Console.WriteLine();
                break;

            case "left exclude":

                if (first.Count < second.Count)
                {
                    int diff = Math.Abs(first.Count - second.Count);

                    for (int i = 0; i < diff; i++)
                    {
                        first.Add(-1);
                    }
                }
                if (second.Count < first.Count)
                {
                    int diff = Math.Abs(first.Count - second.Count);

                    for (int i = 0; i < diff; i++)
                    {
                        second.Add(-1);
                    }
                }

                first.Sort();
                second.Sort();

                for (int i = 0; i < first.Count; i++)
                {
                    for (int j = 0; j < second.Count; j++)
                    {
                        if (first[i] == second[j])
                        {
                            first[i] = '\0';
                            second[j] = '\0';
                        }
                    }
                }

                for (int i = 0; i < second.Count; i++)
                {
                    if (second[i] != 0)
                    {
                        Console.Write(Convert.ToChar(second[i]));
                    }
                }
                Console.WriteLine();
                break;

            case "right exclude":

                if (first.Count < second.Count)
                {
                    int diff = Math.Abs(first.Count - second.Count);

                    for (int i = 0; i < diff; i++)
                    {
                        first.Add(-1);
                    }
                }
                if (second.Count < first.Count)
                {
                    int diff = Math.Abs(first.Count - second.Count);

                    for (int i = 0; i < diff; i++)
                    {
                        second.Add(-1);
                    }
                }

                first.Sort();
                second.Sort();

                for (int i = 0; i < second.Count; i++)
                {
                    for (int j = 0; j < first.Count; j++)
                    {
                        if (first[i] == second[j])
                        {
                            first[i] = '\0';
                            second[j] = '\0';
                        }
                    }
                }

                for (int i = 0; i < first.Count; i++)
                {
                    if (first[i] != 0)
                    {
                        Console.Write(Convert.ToChar(first[i]));
                    }
                }
                Console.WriteLine();
                break;
        }
    }

    static List<int> FillArrayWithNumbers(string p)
    {
        List<int> array = new List<int>();

        for (int i = 0; i < p.Length; i++)
        {
            array.Add(p[i]);
        }

        array.Sort();

        return array;
    }
}
