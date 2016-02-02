using System;

class OddEvenElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputToArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        decimal[] inputAsIntegers = new decimal[inputToArray.Length];

        for (int i = 0; i < inputAsIntegers.Length; i++)
        {
            inputAsIntegers[i] = decimal.Parse(inputToArray[i]);
        }

        decimal oddSum = 0;
        decimal evenSum = 0;

        decimal evenMin = 0;
        decimal evenMax = 0;
        if (inputAsIntegers.Length > 1)
        {
            // Even
            evenMin = decimal.MaxValue;
            evenMax = decimal.MinValue;
            for (int i = 1; i < inputAsIntegers.Length; i += 2)
            {
                evenSum += inputAsIntegers[i];
                if (inputAsIntegers[i] < evenMin)
                {
                    evenMin = inputAsIntegers[i];
                }
                if (inputAsIntegers[i] > evenMax)
                {
                    evenMax = inputAsIntegers[i];
                }
            }

            // Odd
            decimal oddMin = decimal.MaxValue;
            decimal oddMax = decimal.MinValue;
            for (int i = 0; i < inputAsIntegers.Length; i += 2)
            {
                oddSum += inputAsIntegers[i];
                if (inputAsIntegers[i] < oddMin)
                {
                    oddMin = inputAsIntegers[i];
                }
                if (inputAsIntegers[i] > oddMax)
                {
                    oddMax = inputAsIntegers[i];
                }
            }

            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", (double)oddSum, (double)oddMin, (double)oddMax, (double)evenSum, (double)evenMin, (double)evenMax);
        }
        else if (inputAsIntegers.Length == 1)
        {
            decimal oddMin = decimal.MaxValue;
            decimal oddMax = decimal.MinValue;
            for (int i = 0; i < inputAsIntegers.Length; i += 2)
            {
                oddSum += inputAsIntegers[i];
                if (inputAsIntegers[i] < oddMin)
                {
                    oddMin = inputAsIntegers[i];
                }
                if (inputAsIntegers[i] > oddMax)
                {
                    oddMax = inputAsIntegers[i];
                }
            }

            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", (double)oddSum, (double)oddMin, (double)oddMax);
        }
        else
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
    }
}
