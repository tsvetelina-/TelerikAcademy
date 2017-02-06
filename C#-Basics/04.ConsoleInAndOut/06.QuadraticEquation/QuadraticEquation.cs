using System;
using System.Runtime.InteropServices;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double discriminant = Math.Pow(b, 2) - 4*a*c;
        double x1 = (-b + Math.Sqrt(discriminant))/(2*a);
        double x2 = (-b - Math.Sqrt(discriminant))/(2*a);

        if (discriminant > 0)
        {
            if (x1 < x2)
            {
                Console.WriteLine(x1.ToString("0.00"));
                Console.WriteLine(x2.ToString("0.00"));
            }
            else
            {
                Console.WriteLine(x2.ToString("0.00"));
                Console.WriteLine(x1.ToString("0.00"));
            }
        }
        else if (discriminant == 0)
        {
            Console.WriteLine(x1.ToString("0.00"));
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }
}
