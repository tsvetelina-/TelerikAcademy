using System;

class PrintTheASCIITable
{
    static void Main()
    {
        for (char i = (char)33; i < (char)127; i++)
        {
            Console.Write(i);
        }
    }
}
