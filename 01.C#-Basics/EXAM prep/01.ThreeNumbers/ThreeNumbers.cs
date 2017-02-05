using System;

class ThreeNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        double biggestOfThreeNumbers = Math.Max(a, Math.Max(b, c));
        double smallestOfThreeNumbers = Math.Min(a, Math.Min(b, c));

        double average = (double)(a + b + c)/3;

        Console.WriteLine(biggestOfThreeNumbers);
        Console.WriteLine(smallestOfThreeNumbers);
        Console.WriteLine(average.ToString("0.00"));

        //if (a >= b && a >= c)
        //{
        //    if (b <= c)
        //    {
        //        biggestNum = a;
        //        smallestNum = b;
        //    }
        //    else
        //    {
        //        smallestNum = c;
        //    }
        //}
        //else if (b >= a && b >= c)
        //{
        //    if (a <= c)
        //    {
        //        biggestNum = b;
        //        smallestNum = a;
        //    }
        //    else
        //    {
        //        smallestNum = c;
        //    }
        //}
        //else if (c >= a && c >= b)
        //{
        //    if (a <= b)
        //    {
        //        biggestNum = c;
        //        smallestNum = a;
        //    }
        //    else
        //    {
        //        smallestNum = b;
        //    }
        //}
        //double average = (double)(smallestNum + biggestNum)/2;

        //Console.WriteLine(biggestNum);
        //Console.WriteLine(smallestNum);
        //Console.WriteLine(average.ToString("0.00"));
    }
}