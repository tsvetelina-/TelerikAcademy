using System;

class MythicalNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int firstDigit = (number/10)/10;
        int secondDigit = ((number/10)%10);
        int thirdDigit = number % 10;

        double result = 0;

        if (thirdDigit == 0)
        {
            result = firstDigit*secondDigit;
            Console.WriteLine(result.ToString("0.00"));
        }
        else if (thirdDigit > 0 && thirdDigit <= 5)
        {
            result = (double)(firstDigit*secondDigit) / (double)thirdDigit;
            Console.WriteLine(result.ToString("0.00"));
        }
        else if (thirdDigit > 5)
        {
            result += (firstDigit + secondDigit) * thirdDigit;
            Console.WriteLine(result.ToString("0.00"));
        }



        //find the second digit
        //string num = number.ToString();
        //string secondDigit = num.Substring(1, 1);
        //Console.WriteLine(int.Parse(secondDigit));
    }
}
