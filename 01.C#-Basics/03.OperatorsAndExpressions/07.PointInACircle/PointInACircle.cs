using System;

class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        int radius = 2;

        bool isInCircle = ((x*x) + (y*y)) <= Math.Pow(radius, 2);
        double distance = Math.Sqrt(x*x + y*y);

        if (isInCircle)
        {
            Console.WriteLine("yes {0}", distance.ToString("0.00"));
        }
        else
        {
            Console.WriteLine("no {0}", distance.ToString("0.00"));
        }

    }
}
