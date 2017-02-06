using System;

class MixingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int numbers = int.Parse(Console.ReadLine());

            int mixedNumbers = GetFirstDigit(numbers)*GetLastDigit(numbers);
            //int subtractedNumbers = ;
            Console.WriteLine(mixedNumbers);
            //Console.WriteLine(subtractedNumbers);
        }
    }
    public static int GetFirstDigit(int number)
    {
        if (number < 10)
        {
            return number;
        }
        return GetFirstDigit((number - (number % 10)) / 10);
    }

    public static int GetLastDigit(int number)
    {
        if (number < 10)
        {
            return number;
        }
        return GetLastDigit(number%10);
    }
}
//while (true)
//{
//    int start = Convert.ToInt32(numbers.ToString().Substring(0, 1));
//    Console.WriteLine(start);
//}