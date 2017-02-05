using System;

class OddOrEven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("even " + number);
        }
        else if (number % 2 != 0)
        {
            Console.WriteLine("odd " + number);
        }
    }
}
