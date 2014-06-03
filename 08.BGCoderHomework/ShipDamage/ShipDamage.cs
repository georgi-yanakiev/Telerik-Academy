// Task 01. "Telerik Academy Exam 1 @ 6 Dec 2011 Morning"
using System;

class ShipDamage
{
    static void Main(string[] args)
    {
        double shipX1 = int.Parse(Console.ReadLine());
        double shipY1 = int.Parse(Console.ReadLine());
        double shipX2 = int.Parse(Console.ReadLine());
        double shipY2 = int.Parse(Console.ReadLine());

        double horizonY = int.Parse(Console.ReadLine());

        double cannOneX = int.Parse(Console.ReadLine());
        double cannOneY = int.Parse(Console.ReadLine());
        double cannTwoX = int.Parse(Console.ReadLine());
        double cannTwoY = int.Parse(Console.ReadLine());
        double cannThreeX = int.Parse(Console.ReadLine());
        double cannThreeY = int.Parse(Console.ReadLine());

        double shellC1X = cannOneX;
        double shellC1Y = 2 * horizonY - cannOneY;
        double shellC2X = cannTwoX;
        double shellC2Y = 2 * horizonY - cannTwoY;
        double shellC3X = cannThreeX;
        double shellC3Y = 2 * horizonY - cannThreeY;

        double pointsC1 = CannonShot(shipX1, shipY1, shipX2, shipY2, shellC1X, shellC1Y);
        double pointsC2 = CannonShot(shipX1, shipY1, shipX2, shipY2, shellC2X, shellC2Y);
        double pointsC3 = CannonShot(shipX1, shipY1, shipX2, shipY2, shellC3X, shellC3Y);

        Console.WriteLine(pointsC1 + pointsC2 + pointsC3 + "%");
    }

    static double CannonShot(double shipX1, double shipY1, double shipX2, double shipY2, double cX, double cY)
    {
        int points = 0;

        if ((cX > Math.Min(shipX1, shipX2) && cX < Math.Max(shipX1, shipX2)) && (cY > Math.Min(shipY1, shipY2) && cY < Math.Max(shipY1, shipY2)))
        {
            points = 100;
        }
        if ((cX > Math.Min(shipX1, shipX2) && cX < Math.Max(shipX1, shipX2)) && (cY == shipY1 || cY == shipY2) || (cY > Math.Min(shipY1, shipY2) && (cY < Math.Max(shipY1, shipY2)) && (cX == shipX1 || cX == shipX2)))
        {
            points = 50;
        }
        if ((cX == Math.Min(shipX1, shipX2) || cX == Math.Max(shipX1, shipX2)) && (cY == Math.Min(shipY1, shipY2) || cY == Math.Max(shipY1, shipY2)))
        {
            points = 25;
        }

        return points;
    }
}