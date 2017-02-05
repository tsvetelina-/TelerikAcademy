using System;

class CryptoCS
{
    static void Main()
    {
        string hex = Console.ReadLine();

        int decValue = Convert.ToInt32(hex, 16);

        Console.WriteLine(decValue);

    }
}
