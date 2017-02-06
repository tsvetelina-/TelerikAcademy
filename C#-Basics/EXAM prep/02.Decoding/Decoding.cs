using System;

class Decoding
{
    static void Main()
    {
        int salt = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        int position = 0;

        for (int i = 0; i < text.Length; i++)
        {
            long result = 0;

            char currentChar = text[i];
            if (currentChar == '@')
            {
                break;
            }
            if (Char.IsLetter(currentChar))
            {
                result = currentChar * salt + 1000;
            }
            else if (Char.IsDigit(currentChar))
            {
                result = currentChar + salt + 500;
            }
            else
            {
                result = currentChar - salt;
            }

            if (position % 2 == 0) //if position is even divide by 100.0 (instead of cast to double)
            {
                Console.WriteLine((result / 100.0).ToString("0.00"));
            }
            else if (position % 2 != 0) // if position is odd multiply by 100
            {
                Console.WriteLine(result * 100);
            }
            position++;
        }
    }
}