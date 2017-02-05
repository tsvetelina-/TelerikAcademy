using System;

class Circle
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2*Math.PI*radius;
        double area = Math.PI*Math.Pow(radius, 2);

        Console.Write(perimeter.ToString("0.00"));
        Console.WriteLine(" " + area.ToString("0.00"));
    }
}
