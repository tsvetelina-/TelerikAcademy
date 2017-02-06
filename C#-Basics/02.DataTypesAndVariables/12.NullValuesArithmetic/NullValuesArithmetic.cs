using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;

        Console.WriteLine("This is the integer with Null value: " + nullInt);
        Console.WriteLine("This is the double number with Null value: " + nullDouble);
    }
}
