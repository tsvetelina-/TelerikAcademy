using System;

class Calculate
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        double sum = 1 + 1/x;
        long factorial = 1;

        for (int i = 2; i <= n; i++)
        {
            factorial = factorial*i;
            double pow = Math.Pow(x, i);
            sum = sum + (factorial/pow);
        }
        Console.WriteLine("{0:F5}", sum);
    }

}


