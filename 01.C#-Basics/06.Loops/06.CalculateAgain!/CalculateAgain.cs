using System;

class CalculateAgain
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int result = 1;
        for (int i = 1; i < n; i++)
        {
            for (int p = 1; p < k; p++)
            {
                result = result*i;
            }
        }
        Console.WriteLine(result);
    }
}
