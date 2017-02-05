using System;

class ModifyBit
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        byte value = byte.Parse(Console.ReadLine());
        ulong mask = 1;
        ulong numberAndMask;

        if (value == 0)
        {
            numberAndMask = ~(mask << position) & n;
        }
        else
        {
            numberAndMask = n | mask << position;
        }

        Console.WriteLine(numberAndMask);
    }
}
