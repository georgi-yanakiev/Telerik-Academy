// Task 01. "Telerik Academy Exam 1 @ 7 Dec 2011 Morning"
using System;

class FighterAttack
{
    static void Main(string[] args)
    {
        double plantX1 = int.Parse(Console.ReadLine());
        double plantY1 = int.Parse(Console.ReadLine());
        double plantX2 = int.Parse(Console.ReadLine());
        double plantY2 = int.Parse(Console.ReadLine());

        double fighterX = int.Parse(Console.ReadLine());
        double fighterY = int.Parse(Console.ReadLine());
        double distance = int.Parse(Console.ReadLine());

        double pointsC = FighterShot(plantX1, plantY1, plantX2, plantY2, fighterX, fighterY, distance);

        Console.WriteLine(pointsC + "%");
    }

    static double FighterShot(double plantX1, double plantY1, double plantX2, double plantY2, double fighterX, double fighterY, double distance)
    {
        int points = 0;
        double hitCenterX = fighterX + distance;
        double hitCenterY = fighterY;
        double hitDownX = fighterX + distance;
        double hitDownY = fighterY - 1;
        double hitUpX = fighterX + distance;
        double hitUpY = fighterY + 1;
        double hitRightX = fighterX + distance + 1;
        double hitRightY = fighterY;

        if ((hitCenterX >= Math.Min(plantX1, plantX2) && hitCenterX <= Math.Max(plantX1, plantX2)) && (hitCenterY >= Math.Min(plantY1, plantY2) && hitCenterY <= Math.Max(plantY1, plantY2)))
        {
            points += 100;
        }
        if ((hitRightX >= Math.Min(plantX1, plantX2) && hitRightX <= Math.Max(plantX1, plantX2)) && (hitRightY >= Math.Min(plantY1, plantY2) && hitRightY <= Math.Max(plantY1, plantY2)))
        {
            points += 75;
        }
        if ((hitDownX >= Math.Min(plantX1, plantX2) && hitDownX <= Math.Max(plantX1, plantX2)) && (hitDownY >= Math.Min(plantY1, plantY2) && hitDownY <= Math.Max(plantY1, plantY2)))
        {
            points += 50;
        }
        if ((hitUpX >= Math.Min(plantX1, plantX2) && hitUpX <= Math.Max(plantX1, plantX2)) && (hitUpY >= Math.Min(plantY1, plantY2) && hitUpY <= Math.Max(plantY1, plantY2)))
        {
            points += 50;
        }

        return points;
    }
}