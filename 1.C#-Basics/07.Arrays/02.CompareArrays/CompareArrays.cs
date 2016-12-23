using System;

class CompareArrays
{
    static void Main()
    {
        int lengthOfArray = int.Parse(Console.ReadLine());

        int[] firstArray = new int[lengthOfArray];
        int[] secondArray = new int[lengthOfArray];

        bool isEqual = true;

        //read first array
        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        //read second array
        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < lengthOfArray; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }
        }

        if (isEqual)
        {
            Console.WriteLine("Equal");
        }
        else if (isEqual == false)
        {
            Console.WriteLine("Not equal");
        }
    }
}
