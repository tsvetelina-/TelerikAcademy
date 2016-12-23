using System;

class MaximalSequence
{
    static void Main()
    {
        int lengthOfArray = int.Parse(Console.ReadLine());

        int[] nums = new int[lengthOfArray];

        int maxSequence = 0;
        int sequence = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            //read nums from 0 to lengthOfArray
            nums[i] = int.Parse(Console.ReadLine());

            if (nums[i] == nums[i])
            {
                sequence++;
            }
            else
            {
                if (maxSequence < sequence)
                {
                    maxSequence = sequence;
                }
                sequence = 1;
            }
            
        }
        Console.WriteLine(maxSequence);
    }
}
