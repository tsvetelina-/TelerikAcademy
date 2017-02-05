using System;

class Garden
{
    static void Main()
    {
        int tomatoSeedsAmount = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
        int cucumberSeedsAmount = int.Parse(Console.ReadLine());
        int cucucmberArea = int.Parse(Console.ReadLine());
        int potatoSeedsAmount = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());
        int carrotSeedsAmount = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());
        int cabbageSeedsAmount = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());
        int beansSeedsAmount = int.Parse(Console.ReadLine());

        double totalCost = 0;
        int totalArea = 250;
        int usedArea = 0;
        totalCost = (tomatoSeedsAmount * 0.5) + (cucumberSeedsAmount * 0.4) + (potatoSeedsAmount * 0.25) +
                    (carrotSeedsAmount * 0.6) + (cabbageSeedsAmount * 0.3) + (beansSeedsAmount * 0.4);

        usedArea = tomatoArea + cucucmberArea + potatoArea + carrotArea + cabbageArea;
        int beansArea = Math.Abs(totalArea - usedArea);

        Console.WriteLine(totalCost.ToString("Total costs: " + "0.00"));

        if (usedArea < totalArea)
        {
            Console.WriteLine("Beans area: " + beansArea);
        }
        else if (usedArea > totalArea)
        {
            Console.WriteLine("Insufficient area");
        }
        else if (usedArea == totalArea)
        {
            Console.WriteLine("No area for beans");
        }
    }
}