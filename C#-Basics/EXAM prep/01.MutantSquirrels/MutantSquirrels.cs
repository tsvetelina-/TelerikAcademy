using System;

class MutantSquirrels
{
    static void Main()
    {
        double trees = double.Parse(Console.ReadLine());
        double branches = double.Parse(Console.ReadLine());
        double squirrels = double.Parse(Console.ReadLine());
        double tails = double.Parse(Console.ReadLine());


        double allTails = trees*branches*squirrels*tails;
        if ((double)allTails % 2 != 0)
        {
            double result = allTails/7;
            Console.WriteLine(result.ToString("0.000"));
        }
        else
        {
            double result = allTails*376439;
            Console.WriteLine(result.ToString("0.000"));
        }

    }
}
