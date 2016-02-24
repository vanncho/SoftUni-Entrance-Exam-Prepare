using System;
using System.Collections.Generic;
using System.Text;

class DecryptMessages
{
    static void Main()
    {
        List<string> messages = new List<string>();
        bool startRecieving = false;

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "end" || input == "END")
            {
                break;
            }
            else if (input == "start" || input == "START")
            {
                startRecieving = true;
            }
            else
            {
                if (startRecieving && input != string.Empty)
                {
                    string encryptedMessage = EncryptMessageFromCurrentLine(input);
                    messages.Add(encryptedMessage);
                }
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
            Console.WriteLine("No message received.");
        }
    }

    static string EncryptMessageFromCurrentLine(string input)
    {
        StringBuilder message = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            int currentChar = input[i];

            // A -> N
            if (currentChar >= 65 && currentChar <= 77)
            {
                currentChar += 13;
                message.Append(Convert.ToChar(currentChar));
                continue;
            }

            // N -> A
            if (currentChar >= 78 && currentChar <= 90)
            {
                currentChar -= 13;
                message.Append(Convert.ToChar(currentChar));
                continue;
            }

            // a -> n
            if (currentChar >= 97 && currentChar <= 109)
            {
                currentChar += 13;
                message.Append(Convert.ToChar(currentChar));
                continue;
            }

            // n -> a
            if (currentChar >= 110 && currentChar <= 122)
            {
                currentChar -= 13;
                message.Append(Convert.ToChar(currentChar));
                continue;
            }

            // 1 -> 9
            if (currentChar >= 48 && currentChar <= 57)
            {
                message.Append(Convert.ToChar(currentChar));
                continue;
            }

            switch (currentChar)
            {
                case 43: currentChar = 32; message.Append(Convert.ToChar(currentChar)); break;
                case 37: currentChar = 44; message.Append(Convert.ToChar(currentChar)); break;
                case 38: currentChar = 46; message.Append(Convert.ToChar(currentChar)); break;
                case 35: currentChar = 63; message.Append(Convert.ToChar(currentChar)); break;
                case 36: currentChar = 33; message.Append(Convert.ToChar(currentChar)); break;
            }
        }

        string reversed = ReverseMessage(message);
        return reversed;
    }

    static string ReverseMessage(StringBuilder message)
    {
        StringBuilder reversed = new StringBuilder();

        for (int i = message.Length - 1; i >= 0; i--)
        {
            reversed.Append(message[i]);
        }

        return reversed.ToString();
    }
}
