using System;

class TextToNumber1
{
    static void Main()
    {
        int module = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        long result = 0;
        for (int i = 0; i < text.Length; i++)
        {
            char currentChar = text[i];
            if (currentChar == '@')
            {
                continue;
            }
            if (currentChar >= '0' && currentChar <= '9')
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

//http://telerikacademy.com/Courses/LectureResources/Video/8188/%D0%97%D0%B0%D0%B4%D0%B0%D1%87%D0%B0-3-Saddy-Copper-%D0%95%D0%B2%D0%BB%D0%BE%D0%B3%D0%B8
