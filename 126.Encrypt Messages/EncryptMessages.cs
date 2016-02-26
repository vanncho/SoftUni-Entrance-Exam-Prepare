using System;
using System.Collections.Generic;
using System.Text;

class EncryptMessages
{
    static char[] encryptedMessage;

    static void Main()
    {
        bool startRecieve = false;
        List<string> messages = new List<string>();

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "end" || line == "END")
            {
                break;
            }
            else if (line == "start" || line == "START")
            {
                startRecieve = true;
                continue;
            }
            else if (startRecieve && line != string.Empty)
            {
                encryptedMessage = new char [line.Length];
                StartEncryptTheMessage(line);
                string currentMessage = ReverseTheMessage();
                messages.Add(currentMessage);
            }
        }

        if (messages.Count > 0)
        {
            Console.WriteLine("Total number of messages: {0}", messages.Count);

            for (int i = 0; i < messages.Count; i++)
            {
                Console.WriteLine(messages[i]);
            }
        }
        else
        {
            Console.WriteLine("No messages sent.");
        }
    }

    static string ReverseTheMessage()
    {
        StringBuilder reversedMessage = new StringBuilder();

        for (int i = encryptedMessage.Length - 1; i >= 0; i--)
        {
            reversedMessage.Append(encryptedMessage[i]);
        }

        return reversedMessage.ToString();
    }

    static void StartEncryptTheMessage(string message)
    {
        for (int i = 0; i < message.Length; i++)
        {
            int currentChar = message[i];

            if (currentChar >= 65 && currentChar <= 77)
            {
                currentChar += 13;
            }
            else if (currentChar >= 78 && currentChar <= 90)
            {
                currentChar -= 13;
            }
            else if (currentChar >= 97 && currentChar <= 109)
            {
                currentChar += 13;
            }
            else if (currentChar >= 110 && currentChar <= 122)
            {
                currentChar -= 13;
            }
            else
            {
                switch (currentChar)
                {
                    case 32: currentChar = 43; break;
                    case 33: currentChar = 36; break;
                    case 44: currentChar = 37; break;
                    case 46: currentChar = 38; break;
                    case 63: currentChar = 35; break;
                }
            }

            encryptedMessage[i] = Convert.ToChar(currentChar);
        }
    }
}
