using System;

class DecimalToBinary
{
    static void Main()
    {
        long inputLine = long.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(inputLine, 2));
    }
}
