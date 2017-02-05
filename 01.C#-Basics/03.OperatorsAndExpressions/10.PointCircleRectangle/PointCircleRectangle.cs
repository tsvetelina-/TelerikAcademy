using System;

class PointCircleRectangle
{
    static void Main()
    {
        float x = float.Parse(Console.ReadLine());
        float y = float.Parse(Console.ReadLine());

        bool isInCircle = ((x - 1)*(x - 1) + (y - 1)*(y - 1)) <= Math.Pow(1.5, 2);
        bool isInRectangle = (x >= -1 && x <= 5) && (y <= 1 && y >= -1);

        if (isInCircle) 
        {
            Console.Write("inside circle");
        }
        else
        {
            Console.Write("outside circle");
        }
        if (isInRectangle)
        {
            Console.Write(" inside rectangle");
        }
        else
        {
            Console.Write(" outside rectangle");
        }

        Console.WriteLine();
    }
}
