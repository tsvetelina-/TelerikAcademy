using System;

class Program
{
    static void Main()
    {
        double bBirds = double.Parse(Console.ReadLine());
        double fFeathers = double.Parse(Console.ReadLine());

        double feathersPerBird = fFeathers/bBirds;
        double result = 0;
        if (bBirds % 2 == 0)
        {
            result += feathersPerBird*123123123123;
        }
        else if (bBirds % 2 != 0)
        {
            result += feathersPerBird/317;
        }
        Console.WriteLine(result.ToString("0.0000"));
    }
}
