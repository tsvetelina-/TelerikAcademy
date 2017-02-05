using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int temp;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        Console.WriteLine("after the exchange: ");
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}
