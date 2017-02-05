using System;

class TextToNumber
{
    static void Main()
    {
        int module = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        long result = 0;
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (ch == '@')
            {
                break;
            }
            if (ch >= '0' && ch <= '9')
            {
                result *= (ch - '0');
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                result += (ch - 'a');
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                result += (ch - 'A');
            }
            else
            {
                result %= module;
            }
        }
        Console.WriteLine(result);
    }
}
