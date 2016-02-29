using System;

class FallenInLove
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int outsideTopDots = 2 * n;
        Console.WriteLine("##{0}##{0}##", new string('.', outsideTopDots));
        
        int signOfLeaves = 1;
        outsideTopDots -= 2;
        int insideTopDots = 2;

        for (int i = 0; i < n - 1; i++)
        {
            Console.Write("#");
            Console.Write(new string('~', signOfLeaves));
            Console.Write("#");
            Console.Write(new string('.', outsideTopDots));
            Console.Write("#");
            Console.Write(new string('.', insideTopDots));
            Console.Write("#");
            Console.Write(new string('.', outsideTopDots));
            Console.Write("#");
            Console.Write(new string('~', signOfLeaves));
            Console.WriteLine("#");
            signOfLeaves++;
            outsideTopDots -= 2;
            insideTopDots += 2;
        }

        // middle
        signOfLeaves = n;
        outsideTopDots = 1;
        //insideTopDots += 2;
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', outsideTopDots));
            Console.Write("#");
            Console.Write(new string('~', signOfLeaves));
            Console.Write("#");
            Console.Write(new string('.', insideTopDots));
            Console.Write("#");
            Console.Write(new string('~', signOfLeaves));
            Console.Write("#");
            Console.WriteLine(new string('.', outsideTopDots));
            signOfLeaves--;
            outsideTopDots += 2;
            insideTopDots -= 2;
        }

        //
        Console.WriteLine("{0}####{0}", new string('.', outsideTopDots));
        outsideTopDots += 2;
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', outsideTopDots - 1));
            Console.Write(new string('#', 2));
            Console.WriteLine(new string('.', outsideTopDots - 1));
        }
    }
}
