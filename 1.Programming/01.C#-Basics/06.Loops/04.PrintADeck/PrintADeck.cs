﻿using System;

class PrintADeck
{
    static void Main()
    {
        string card = Console.ReadLine();
        string[] array = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        for (int i = 0; i <= Array.IndexOf(array, card); i++)
        {
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", array[i]);
        }
    }
}
