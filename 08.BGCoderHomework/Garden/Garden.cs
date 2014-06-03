// Task 01 "Telerik Academy Exam 1 @ 24 June 2013 Evening"
using System;

class Garden
{
    static void Main(string[] args)
    {
        double tomatoSeeds = double.Parse(Console.ReadLine());
        double tomatoArea = double.Parse(Console.ReadLine());
        double cucumberSeeds = double.Parse(Console.ReadLine());
        double cucumberArea = double.Parse(Console.ReadLine());
        double potatoSeeds = double.Parse(Console.ReadLine());
        double potatoArea = double.Parse(Console.ReadLine());
        double carrotSeeds = double.Parse(Console.ReadLine());
        double carrotArea = double.Parse(Console.ReadLine());
        double cabbageSeeds = double.Parse(Console.ReadLine());
        double cabbageArea = double.Parse(Console.ReadLine());
        double beansSeeds = double.Parse(Console.ReadLine());
        double beansArea = 0;
        double totalArea = 250;
        double totalCost = (tomatoSeeds * 0.5) + (cucumberSeeds * 0.4) + (potatoSeeds * 0.25) + (carrotSeeds * 0.6) + (cabbageSeeds * 0.3) + (beansSeeds * 0.4);
        beansArea = (tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea);
        Console.WriteLine("Total costs: {0:0.00}", totalCost);
        if (totalArea > beansArea)
        {
            Console.WriteLine("Beans area: {0}", totalArea - beansArea);
        }
        else if (totalArea == beansArea)
        {
            Console.WriteLine("No area for beans");
        }
        else if (totalArea < beansArea)
        {
            Console.WriteLine("Insufficient area");
        }
    }
}