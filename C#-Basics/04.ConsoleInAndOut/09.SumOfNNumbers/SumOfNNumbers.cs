using System;

class SumOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;

        for (double i = 0; i < n; i++)
        {
            double nums = double.Parse(Console.ReadLine());
            sum += nums;
        }
        Console.WriteLine(sum);
    }
}
