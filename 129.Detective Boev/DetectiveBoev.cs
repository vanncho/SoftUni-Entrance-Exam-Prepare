using System;

class DetectiveBoev
{
    static void Main()
    {
        string secretWord = Console.ReadLine();
        string encryptedMessage = Console.ReadLine();

        int mask = 0;

        for (int i = 0; i < secretWord.Length; i++)
        {
            mask += secretWord[i];
        }

        int temp = mask;
        //

        while (mask > 9)
        {
            mask = 0;

            while (temp > 0)
            {
                int digit = temp % 10;
                mask += digit;
                temp /= 10;
            }

            temp = mask;
        }


        char[] decryptedMessage = new char[encryptedMessage.Length];

        for (int i = 0; i < encryptedMessage.Length; i++)
        {
            int currentChar = encryptedMessage[i];

            if (currentChar % mask == 0)
            {
                decryptedMessage[i] = Convert.ToChar(currentChar + mask);
            }
            else
            {
                decryptedMessage[i] = Convert.ToChar(currentChar - mask);
            }
        }

        for (int i = decryptedMessage.Length - 1; i >= 0; i--)
        {
            Console.Write(decryptedMessage[i]);
        }
        Console.WriteLine();
    }
}
