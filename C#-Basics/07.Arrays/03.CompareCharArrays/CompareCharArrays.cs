using System;

class CompareCharArrays
{
    static void Main()
    {
        string firstArray = Console.ReadLine();
        string secondArray = Console.ReadLine();

        if (firstArray.Length == secondArray.Length)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine(">");
                    break;
                }
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("<");
                    break;
                }
                else
                {
                    Console.WriteLine("=");
                    break;
                }
            }

            if (firstArray.Length < secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] > secondArray[i])
                    {
                        Console.WriteLine(">");
                        break;
                    }
                    if (firstArray[i] < secondArray[i])
                    {
                        Console.WriteLine("<");
                        break;
                    }
                }
            }
            if (secondArray.Length < firstArray.Length)
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                    if (firstArray[i] > secondArray[i])
                    {
                        Console.WriteLine(">");
                        Environment.Exit(0);
                    }
                    if (firstArray[i] < secondArray[i])
                    {
                        Console.WriteLine("<");
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
