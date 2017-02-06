using System;

class NumberOfPages
{
    static void Main()
    {
        int digits = int.Parse(Console.ReadLine());

        int pages = 0;

        for (int page = 1; digits != 0; page++)
        {
            pages++;
            digits -= page.ToString().Length;
        }

        Console.WriteLine(pages);
    }
}
