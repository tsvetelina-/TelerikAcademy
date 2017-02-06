using System;

class EncodingSum
{
    static void Main()
    {
        int module = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        long result = 0;
        foreach (var currentChar in text)
        {
            if (currentChar == '@')
            {
                break;
            }
            else if (currentChar >= '0' && currentChar <= '9')
            {
                result *= (currentChar - '0');
            }
            else if (currentChar >= 'a' && currentChar <= 'z')
            {
                result += (currentChar - 'a');
            }
            else if (currentChar >= 'A' && currentChar <= 'Z')
            {
                result += (currentChar - 'A');
            }
            else
            {
                result %= module;
            }
        }
        Console.WriteLine(result);
    }
}
