using System;

class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = width*height;
        double perimeter = 2 * (width + height);

        Console.WriteLine(area.ToString("0.00") + " " + perimeter.ToString("0.00"));
    }
}
