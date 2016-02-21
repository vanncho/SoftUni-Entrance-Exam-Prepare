using System;

class SpyHard
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        string message = Console.ReadLine().ToLower();

        int sum = 0;
        for (int i = 0; i < message.Length; i++)
        {
            if (char.IsLetter(message[i]))
            {
                sum += message[i] - 96;
            }
            else
            {
                sum += message[i];
            }
        }

        string res = "";

        if (key < 10)
        {
            while (sum != 0)
            {
                int rest = sum % key;
                res += "" + rest;
                sum = sum / key;
            }

            string final = "";
            for (int i = res.Length - 1; i >= 0; i--)
            {
                final += res[i];
            }
            Console.WriteLine("{0}{1}{2}", key, message.Length, final);
        }
        else
        {
            Console.WriteLine("{0}{1}{2}", key, message.Length, sum);
        }

    }
}
