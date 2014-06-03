// 09. Write an expression that checks for given point (x, y) 
// if it is within the circle K( (1,1), 3) and out of the 
// rectangle R(top=1, left=-1, width=6, height=2).

using System;

class CircleAndRectangle
{
    static bool IsItInRectangle(double x, double y) // Method to define if the point is within the Rectangle
    {
        bool inRectangle = true;

        if ((x > 1 && x < 7) && (y < -1 && y > -3))
        {
            inRectangle = false;
        }

        return inRectangle;
    }

    static bool IsItInCircle(double x, double y) // Method to define if the point is within the Circle
    {
        double centX = 1;
        double centY = 1;
        double radius = 3;
        bool inCircle = false;

        if (Math.Pow((x - centX), 2) + Math.Pow((y - centY), 2) <= radius * radius) // check condition if the point is in the circle
        {
            inCircle = true;
        }

        return inCircle;
    }

    static void Main(string[] args)
    {
        Console.Title = "Circle And Rectangle";
        Console.Write("Enter X coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter Y coordinate: ");
        double y = double.Parse(Console.ReadLine());

        bool inCircle = IsItInCircle(x, y);
        bool inRectangle = IsItInRectangle(x, y);

        if (inCircle && inRectangle) // the point must be only in the circle, but not in the rectangle. In any other case, the point is outside the circle.
        {
            Console.WriteLine("The point is within the circle.");
        }
        else
        {
            Console.WriteLine("The point is outside the circle.");
        }
    }
}