using System;

class SymbolToNumber
{
    static void Main()
    {
        int secretNum = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        long result = 0;
        int position = 0;
        for (int i = 0; i < text.Length; i++)
        {
            var character = text[i];
            if (character == '@')
            {
                break;
            }
            if (Char.IsLetter(character))
            {
                result = character * secretNum + 1000;
            }
            else if (Char.IsDigit(character))
            {
                result = character + secretNum + 500;
            }
            else
            {
                result = character - secretNum;
            }

            if (position % 2 == 0)
            {
                Console.WriteLine((result / 100.0).ToString("0.00"));

            }
            else
            {
                Console.WriteLine(result * 100);
            }
            position++;

        }
    }
}