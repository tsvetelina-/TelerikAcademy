using System;

class FirstProblem248
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int function = 0;
        int firstInputLine = 0;
        if (b == 2)
        {
            function = ()Math.Round(a%c);
        }
        else if (b == 4)
        {
            function = a + c;
        }
        else if (b == 8)
        {
            function = a*c;
        }
        
        if (function % 4 == 0)
        {
            firstInputLine = function / 4;
        }
        else
        {
            firstInputLine = 1;
        }
        Console.WriteLine(firstInputLine);
        Console.WriteLine(function);
        Console.WriteLine(Math.Round(1.66666666));

    }
}
