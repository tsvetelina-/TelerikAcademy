using System;

class MoonGravity
{
    static void Main()
    {
        float weight = float.Parse(Console.ReadLine());

        float weightOnTheMoon = weight * 0.17f;

        Console.WriteLine(weightOnTheMoon.ToString("0.000"));
    }
}
