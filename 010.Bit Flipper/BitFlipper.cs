using System;
using System.Text;

class BitFlipper
{
    static void Main()
    {
        //8773276988229695713
        //594226797558350599
        ulong number = ulong.Parse(Console.ReadLine());
        string numberAsBits = ConvertToBinary(number);
        StringBuilder appendDigits = new StringBuilder();
        appendDigits.Append(numberAsBits);
        //0111100111000000111100001111000000011111100010100011100011100001
        //                          ако има грешен отговор да допълня дължината до 64!

        int count = 1;
        int startIndex = 0;
        char currentDigit = new char();
        int tempDigit = numberAsBits[0];

        for (int i = 1; i < appendDigits.Length; i++)
        {
            if (tempDigit == appendDigits[i])
            {
                if (appendDigits[i] != appendDigits[i - 1])
                {
                    continue;
                }
                else
                {
                    startIndex = i - 1;
                    currentDigit = appendDigits[i];
                    count++;
                }
            }
            else
            {
                tempDigit = appendDigits[i];
                count = 1;
            }

            if (count == 3)
            {
                char newDigit = new char();
                if (currentDigit == '1')
	            {
		            newDigit = '0';
	            }
                if (currentDigit == '0')
	            {
		            newDigit = '1';
	            }

                appendDigits.Replace(currentDigit, newDigit, startIndex - 1, 3);
                count = 1;
            }
        }

        
        ulong result = Convert.ToUInt64(appendDigits.ToString(), 2);
        Console.WriteLine(result);
    }

    static string ConvertToBinary(ulong value)
    {
        if (value == 0) return "0";
        System.Text.StringBuilder b = new System.Text.StringBuilder();
        while (value != 0)
        {
            b.Insert(0, ((value & 1) == 1) ? '1' : '0');
            value >>= 1;
        }

        int diff = 64 - b.Length;
        string tempBinary = b.ToString();
        b.Clear();
        b.Append('0', diff);
        b.Append(tempBinary);

        return b.ToString();
    }
}
