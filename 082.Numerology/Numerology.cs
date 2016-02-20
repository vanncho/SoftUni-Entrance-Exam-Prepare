using System;

class Numerology
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] {'.',' '},StringSplitOptions.RemoveEmptyEntries);
        int[] date = new int[3];
        string username = string.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            if (i < 3)
            {
                date[i] = int.Parse(input[i]);
            }
            else
            {
                username = input[i];
            }
        }

        int multiplyOfBirthdate = date[0] * date[1] * date[2];
        ulong result = 0;

        if (date[1] % 2 != 0)
        {
            result = (ulong)multiplyOfBirthdate * (ulong)multiplyOfBirthdate;
        }
        else
        {
            result = (ulong)multiplyOfBirthdate;
        }

        for (int i = 0; i < username.Length; i++)
        {
            int digit = 0;
            if (char.IsLetter(username[i]))
            {
                if (char.IsUpper(username[i]))
                {
                    digit = 2 * (username[i] - 64);
                }
                else
                {
                    digit = username[i] - 96;
                }
            }
            else
            {
                digit = int.Parse(username[i].ToString());
            }

            result += (ulong)digit;
        }

        ulong newResult = 0;

        while (true)
        {
            while (result > 0)
            {
                ulong digit = result % 10;
                result = result / 10;
                newResult += digit;
            }

            if (newResult <= 13)
            {
                break;
            }
            else
            {
                result = newResult;
                newResult = 0;
            }
        }

        Console.WriteLine(newResult);
    }
}
