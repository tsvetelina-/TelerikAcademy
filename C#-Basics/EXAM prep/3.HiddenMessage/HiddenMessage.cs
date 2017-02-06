using System;

class HiddenMessage
{
    static void Main()
    {
        //If the starting index is larger than the length of the line, this means that the line should be skipped
        string hiddenMessage = "";
        while (true)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int symbolsToSkip = int.Parse(Console.ReadLine());
            string text = "add carbon additive"; //Console.ReadLine();
            string decodedMessage = text.Substring(startIndex, 1);
            Console.WriteLine(decodedMessage);

            if (startIndex.ToString() == "end" || symbolsToSkip.ToString() == "end") //|| text == "end")
            {
                //Console.WriteLine(hiddenMessage);
                break;
            }

        }
    }
}