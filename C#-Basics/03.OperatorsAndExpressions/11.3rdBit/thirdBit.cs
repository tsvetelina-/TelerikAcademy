using System;

class thirdBit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int moveRight = number >> 3;
        int mask = 1;
        int result = moveRight & mask;

        Console.WriteLine(result);
    }
}
