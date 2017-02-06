using System;

class VariableInHexadecimalFormat
{
    static void Main()
    {
        int number = 254;
        string hexValue = number.ToString("X");
        Console.WriteLine(hexValue);
    }
}
