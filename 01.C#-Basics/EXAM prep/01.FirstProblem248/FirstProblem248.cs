using System;

class FirstProblem248
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double secondOutputLine = 0;
        double firstOutputLine = 0;
        if (b == (double)2)
        {
            secondOutputLine = (double)a % c;
        }
        else if (b == 4)
        {
            secondOutputLine = a + c;
        }
        else if (b == 8)
        {
            secondOutputLine = a * c;
        }
        if ((double)secondOutputLine % 4 == 0)
        {
            firstOutputLine = secondOutputLine/4;
        }
        else
        {
            firstOutputLine = secondOutputLine%4;
        }
        Console.WriteLine(firstOutputLine);
        Console.WriteLine(secondOutputLine);
    }
}