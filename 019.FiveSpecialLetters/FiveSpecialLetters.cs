using System;
using System.Collections.Generic;
using System.Text;

class FiveSpecialLetters
{
    static void Main()
    {
        char[] sequencesLetters = new char[] { 'a', 'b', 'c', 'd', 'e' };
        int[] weighLetter = new int[] { 5, -12, 47, 7, -32 };

        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        var numbersFromStartToEnd = FindNumbersFromStartToEnd(start, end);
        int count = 0;
        List<string> finalResult = new List<string>();
        //b   c   e   a   d
        //-12   47  -32     5   7
        for (char l1 = 'a'; l1 <= 'e'; l1++)
        {
            for (char l2 = 'a'; l2 <= 'e'; l2++)
            {
                for (char l3 = 'a'; l3 <= 'e'; l3++)
                {
                    for (char l4 = 'a'; l4 <= 'e'; l4++)
                    {
                        for (char l5 = 'a'; l5 <= 'e'; l5++)
                        {
                            //int indexOfL1 = Array.IndexOf(sequencesLetters, l1);
                            //int indexOfL2 = Array.IndexOf(sequencesLetters, l2);
                            //int indexOfL3 = Array.IndexOf(sequencesLetters, l3);
                            //int indexOfL4 = Array.IndexOf(sequencesLetters, l4);
                            //int indexOfL5 = Array.IndexOf(sequencesLetters, l5);
                            string word = l1.ToString() + l2.ToString() + l3.ToString() + l4.ToString() + l5.ToString();
                            string searchWord = ProcessTheLetters(word);
                            int sum = 0;
                            for (int i = 0; i < numbersFromStartToEnd.Count; i++)
                            {
                                sum = CalculateTheWeight(weighLetter, sequencesLetters, numbersFromStartToEnd[i], searchWord);

                                if (sum == numbersFromStartToEnd[i])
                                {
                                    finalResult.Add(word);
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            for (int i = 0; i < finalResult.Count; i++)
            {
                if (i < finalResult.Count)
                {
                    Console.Write("{0} ", finalResult[i]);
                }
                else
                {
                    Console.Write("{0}", finalResult[i]);
                }
            }
            Console.WriteLine();
        }
    }

    static int CalculateTheWeight(int[] weighLetter, char[] sequencesLetters, int numberFromStartToEnd, string searchWord)
    {
        int sum = 0;
        searchWord = "!" + searchWord;
        for (int i = 1; i < searchWord.Length; i++)
        {
            int index = Array.IndexOf(sequencesLetters, searchWord[i]);
            sum += weighLetter[index] * i;
        }

        return sum;
    }

    static List<int> FindNumbersFromStartToEnd(int start, int end)
    {
        var list = new List<int>();

        for (int i = start; i <= end; i++)
        {
            list.Add(i);
        }

        return list;
    }

    static string ProcessTheLetters(string word)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < 5; i++)
        {
            if (i == 0)
            {
                sb.Append(word[i]);
                continue;
            }
            else
            {
                if (sb.ToString().IndexOf(word[i]) < 0)
                {
                    sb.Append(word[i]);
                }
            }
        }
        return sb.ToString();
    }
}
