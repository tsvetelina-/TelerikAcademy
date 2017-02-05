using System;

class OddAndEvenProduct
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sumOdd = 0;
        int sumEven = 0;

        for (int i = 0; i < n; i++)
        {
            int numbers = int.Parse(Console.ReadLine().Split(" "));
        }

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                sumEven += i;
            }
        }
        Console.WriteLine(sumEven);
    }
}
