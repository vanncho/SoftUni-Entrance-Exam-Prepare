using System;
using System.Numerics;
using System.Text;

class EncryptedMatrix
{
    static void Main()
    {
        string message = Console.ReadLine();
        char direction = char.Parse(Console.ReadLine());

        BigInteger converted = ConvertTheMessage(message);

        if (converted.ToString().Length < 2)
        {
            Console.WriteLine(converted);
        }
        else
        {
            string encrypted = EncryptConvertedNumber(converted);

            int matrixSize = encrypted.ToString().Length;
            int[,] matrix = new int[matrixSize, matrixSize];

            // direction is: / (47)
            if (direction == '/')
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                    {
                        if (i == j)
                        {
                            int pos = matrixSize - 1 - j;
                            matrix[i, j] = int.Parse(encrypted[pos].ToString());
                            Console.Write("{0} ", matrix[i, j]);
                        }
                        else
                        {
                            matrix[i, j] = 0;
                            Console.Write("{0} ", matrix[i, j]);
                        }
                    }

                    Console.WriteLine();
                }
            }
            else // direction is: \ (97)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (i == j)
                        {
                            matrix[i, j] = int.Parse(encrypted[i].ToString());
                            Console.Write("{0} ", matrix[i, j]);
                        }
                        else
                        {
                            matrix[i, j] = 0;
                            Console.Write("{0} ", matrix[i, j]);
                        }
                    }

                    Console.WriteLine();
                }
            }
        }
    }

    static string EncryptConvertedNumber(BigInteger converted)
    {
        StringBuilder encrypted = new StringBuilder();
        string convertedToString = converted.ToString();

        for (int i = 0; i < convertedToString.Length; i++)
        {
            int temp = 0;

            // first
            if (i == 0)
            {
                if (int.Parse(convertedToString[i].ToString()) % 2 == 0)
                {
                    temp = int.Parse(convertedToString[i].ToString()) * int.Parse(convertedToString[i].ToString());
                    encrypted.Append(temp.ToString());
                    continue;
                }
                else
                {
                    temp = int.Parse(convertedToString[i].ToString()) + int.Parse(convertedToString[i + 1].ToString());
                    encrypted.Append(temp.ToString());
                    continue;
                }

            }

            if (int.Parse(convertedToString[i].ToString()) % 2 == 0 || int.Parse(convertedToString[i].ToString()) == 0)
            {
                temp = int.Parse(convertedToString[i].ToString()) * int.Parse(convertedToString[i].ToString());
                encrypted.Append(temp.ToString());
                continue;
            }

            if (int.Parse(convertedToString[i].ToString()) % 2 != 0 && i < convertedToString.Length - 1)
            {
                temp = int.Parse(convertedToString[i].ToString()) + int.Parse(convertedToString[i + 1].ToString()) + int.Parse(convertedToString[i - 1].ToString());
                encrypted.Append(temp.ToString());
                continue;
            }

            // last
            if (i == convertedToString.Length - 1)
            {
                if (int.Parse(convertedToString[i].ToString()) % 2 == 0)
                {
                    temp = int.Parse(convertedToString[i].ToString()) * int.Parse(convertedToString[i].ToString());
                    encrypted.Append(temp.ToString());
                    continue;
                }
                else
                {
                    temp = int.Parse(convertedToString[i].ToString()) + int.Parse(convertedToString[i - 1].ToString());
                    encrypted.Append(temp.ToString());
                    continue;
                }

            }
        }

        return encrypted.ToString();
    }

    static BigInteger ConvertTheMessage(string message)
    {
        BigInteger converted = 0;

        for (int i = 0; i < message.Length; i++)
        {
            BigInteger temp = (BigInteger)message[i] % 10;
            converted += temp;
            converted *= 10;
        }

        return converted /= 10;
    }
}
