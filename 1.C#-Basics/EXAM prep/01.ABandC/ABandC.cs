using System;

class ABandC
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int biggest = Math.Max(a, Math.Max(b, c));
        int smallest = Math.Min(a, Math.Min(b, c));
        double average = (double)(a + b + c)/3.0;

        Console.WriteLine(biggest);
        Console.WriteLine(smallest);
        Console.WriteLine(average.ToString("0.000"));
    }
}
