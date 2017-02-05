using System;

class MMSAOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double min = int.MaxValue;
        double max = int.MinValue;
        double sum = 0;
        double average = 0;
        for (int i = 0; i < n; i++)
        {
            double input = double.Parse(Console.ReadLine());

            sum += input;
            average = sum/n;

            if (input < min)
            {
                min = input;
            }
            if (input > max)
            {
                max = input;
            }
        }
        Console.WriteLine("min=" + min.ToString("0.00"));
        Console.WriteLine("max=" + max.ToString("0.00"));
        Console.WriteLine("sum=" + sum.ToString("0.00"));
        Console.WriteLine("avg=" + average.ToString("0.00"));
    }
}
