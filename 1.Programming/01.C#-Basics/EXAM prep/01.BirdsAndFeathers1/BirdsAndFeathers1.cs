using System;

class BirdsAndFeathers1
{
    static void Main()
    {
        double birds = double.Parse(Console.ReadLine());
        double feathers = double.Parse(Console.ReadLine());

        double avgFeathersPerBird = feathers/birds;
        double result = 0;

        if (birds % 2 != 0)
        {
            result = avgFeathersPerBird/317;
        }
        if (birds % 2 == 0)
        {
            result = avgFeathersPerBird*123123123123;
        }

        Console.WriteLine(result.ToString("0.0000"));

    }
}
