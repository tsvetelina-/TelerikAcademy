using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int previousNum = 0;
        int nextNum = 1;
        int thirdNum = 1;

        if (n == 1)
        {
            Console.WriteLine("0");
        }
        else
        {
            thirdNum = previousNum + nextNum;
            previousNum = nextNum;
            nextNum = thirdNum;
            Console.Write(nextNum + ", ");
        }
    }
}