using System;

class CheckForAPlayCard
{
    static void Main()
    {
        string cardFace = Console.ReadLine();

        if (cardFace == "2" || cardFace == "3" || cardFace == "4" || cardFace == "5" 
            || cardFace == "6" || cardFace == "7" || cardFace == "8" || cardFace == "9" || cardFace == "10"
            || cardFace == "J" || cardFace == "Q" || cardFace == "K" || cardFace == "A")
        {
            Console.WriteLine("yes " + cardFace);
        }
        else
        {
            Console.WriteLine("no " + cardFace);
        }
    }
}
