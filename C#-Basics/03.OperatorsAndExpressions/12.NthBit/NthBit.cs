using System;

class NthBit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        long mask = 1 << p;
        long nAndMask = n & mask;
        long bit = nAndMask >> p;

        Console.WriteLine(bit);
    }
}