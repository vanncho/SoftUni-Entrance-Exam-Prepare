using System;
using System.Text;

class FriendBits
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());

        string b = Convert.ToString(n, 2);

        StringBuilder bits = new StringBuilder();
        bits.Append(b);
        StringBuilder friendBits = new StringBuilder();
        StringBuilder aloneBits = new StringBuilder();
        // 11101010011011010000111010110001
        int count = 0;
        while (count < bits.Length - 1)
        {
            char currentBit = bits[count];
            char nextBit = bits[count + 1];
            if (currentBit == nextBit)
            {
                friendBits.Append(bits[count]);
            }
            if (currentBit != nextBit)
            {
                aloneBits.Append(currentBit);
            }

            while (nextBit == currentBit)
            {
                friendBits.Append(bits[count]);
                count++;
                currentBit = bits[count];
                if (count == bits.Length - 1)
                {
                    break;
                }
                else
                {
                    nextBit = bits[count + 1];
                }
                
            }
            count++;
        }
        if (friendBits.Length + aloneBits.Length < bits.Length)
        {
            aloneBits.Append(bits[bits.Length - 1]);
        }

        if (friendBits.Length != 0)
        {
            uint f = Convert.ToUInt32(friendBits.ToString(), 2);
            Console.WriteLine(f);
        }
        else
        {
            Console.WriteLine(0);
        }

        if (aloneBits.Length != 0)
        {
            uint s = Convert.ToUInt32(aloneBits.ToString(), 2);
            Console.WriteLine(s);
        }
        else
        {
            Console.WriteLine(0);
        }
        
    }
}
