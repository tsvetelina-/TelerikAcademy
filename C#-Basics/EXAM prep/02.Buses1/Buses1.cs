using System;

class Buses1
{
    static void Main()
    {
        int numberOfBuses = int.Parse(Console.ReadLine());

        int groups = 0;
        int groupSpeed = int.MaxValue;

        for (int i = 0; i < numberOfBuses; i++)
        {
            int busSpeed = int.Parse(Console.ReadLine());

            if (busSpeed <= groupSpeed)
            {
                groups++;
                groupSpeed = busSpeed;
            }
        }

        Console.WriteLine(groups);
    }
}
