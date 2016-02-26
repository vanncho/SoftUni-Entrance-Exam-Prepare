using System;
using System.Numerics;
using System.Text;

class PetarGame
{
    static void Main()
    {
        ulong startNum = ulong.Parse(Console.ReadLine());
        ulong endNum = ulong.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        BigInteger sum = 0;

        for (ulong i = startNum; i < endNum; i++)
        {
            if (i % 5 == 0)
            {
                sum += i;
            }
            else
            {
                sum += i % 5;
            }
        }

        string numToString = sum.ToString();
        string[] array = new string[numToString.Length];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = numToString[i].ToString();
        }

        int start = 0;

        if (sum % 2 != 0)
        {
            // sum is odd
            string lastDigit = (sum % 10).ToString();
            array[array.Length - 1] = text;

            for (int i = start; start < array.Length - 1; i++)
            {
                int indexOfLastDigit = Array.IndexOf(array, lastDigit.ToString(), start);

                if (indexOfLastDigit < 0)
                {
                    break;
                }
                else
                {
                    array[indexOfLastDigit] = text;
                    start = indexOfLastDigit + 1;
                }
            }
        }
        else
        {
            start = 1;
            // sum is even
            string firstDigit = numToString[0].ToString();
            array[0] = text;

            for (int i = start; start < array.Length; i++)
            {
                int indexOfFirstDigit = Array.IndexOf(array, firstDigit.ToString(), start);

                if (indexOfFirstDigit < 0)
                {
                    break;
                }
                else
                {
                    array[indexOfFirstDigit] = text;
                    start = indexOfFirstDigit + 1;
                }
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }
}
