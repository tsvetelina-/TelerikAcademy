using System;

class PrimeCheck
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
       
        string result = "true";

       
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                result = "false";
            }
        }
        if (number < 0)
        {
            result = "false";
        }

        Console.WriteLine(result);

    }
}
