using System;

class AllocateArray
{
    static void Main()
    {
        int lengthOfArray = int.Parse(Console.ReadLine());

        //array 
        int[] array = new int[lengthOfArray];

        //multiply its index by 5
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(i * 5);
        }
    }
}