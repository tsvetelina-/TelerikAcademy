using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        string binary = Convert.ToString(a, 2);

        Console.WriteLine("{0} |{1}| {2}|{3} |", a.ToString("X"), binary.PadLeft(10, '0'), b.ToString("0.00"), c.ToString("0.000"));

    }
}
