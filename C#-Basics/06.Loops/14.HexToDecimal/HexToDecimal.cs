using System;

class HexToDecimal
{
    static void Main()
    {
        string hex = Console.ReadLine();
        long decValue = Convert.ToInt64(hex, 16);
        Console.WriteLine(decValue);
    }
}