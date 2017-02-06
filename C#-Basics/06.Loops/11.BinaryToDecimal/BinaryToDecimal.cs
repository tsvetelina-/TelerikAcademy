using System;

class BinaryToDecimal
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        Console.WriteLine(Convert.ToInt32(inputLine, 2));
    }
}
