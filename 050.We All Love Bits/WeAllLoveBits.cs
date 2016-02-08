using System;
using System.Text;

class WeAllLoveBits
{
    static StringBuilder processTheBits = new StringBuilder();
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] invertedBits = new string[n];
        string[] reversedBits = new string[n];
        int[] numberOfp = new int[n];

        for (int i = 0; i < n; i++)
        {
            int line = int.Parse(Console.ReadLine());
            string currentNumber = Convert.ToString(line, 2);
            numberOfp[i] = line;

            invertedBits[i] = InvertTheBits(currentNumber);
            processTheBits.Clear();
            reversedBits[i] = ReverseTheBits(currentNumber);
            processTheBits.Clear();

            //Pnew = (P ^ P̃) & P̈.
            int xor = numberOfp[i] ^ Convert.ToInt32(invertedBits[i], 2);
            int and = xor & Convert.ToInt32(reversedBits[i], 2);

            Console.WriteLine(and);
        }
    }

    static string ReverseTheBits(string currentNumber)
    {
        for (int i = currentNumber.Length - 1; i >= 0; i--)
        {
            processTheBits.Append(currentNumber[i]);
        }

        return processTheBits.ToString();
    }

    static string InvertTheBits(string currentNumber)
    {
        //processTheBits.Append(currentNumber);

        for (int i = 0; i < currentNumber.Length; i++)
        {
            if (currentNumber[i] == '0')
            {
                processTheBits.Append('1');
            }
            else
            {
                processTheBits.Append('0');
            }
        }

        return processTheBits.ToString();
    }

    static void ClearTheZerosFromTheLeft(StringBuilder processTheBits)
    {
        for (int i = 0; i < processTheBits.Length; i++)
        {
            if (processTheBits[i] == '1')
            {
                break;
            }
            else
            {
                processTheBits.Remove(i, 1);
                i--;
            }
        }
    }
}

