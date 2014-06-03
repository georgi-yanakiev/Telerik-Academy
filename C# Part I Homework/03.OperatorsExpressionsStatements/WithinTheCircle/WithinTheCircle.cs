// 06. Write an expression that checks if given point 
// (x,  y) is within a circle K(O, 5).

using System;

class WithinTheCircle
{
    static void Main(string[] args)
    {
        Console.Title = "Within The Circle";
        Console.Write("Enter the X coordinate: ");
        int x = Math.Abs(int.Parse(Console.ReadLine()));
        Console.Write("Enter the Y coordinate: ");
        int y = Math.Abs(int.Parse(Console.ReadLine()));
        double z = 0;

        z = Math.Sqrt(((x * x) + (y * y))); // usage of Pythagorean theorem z^2 = x^2 + y^2 
                                                         // to define the distance of the point from the center 
        if (z < 5)
        {
            Console.WriteLine("The Point is within the circle.");
        }
        else if (z == 5)
        {
            Console.WriteLine("The Point is laying on the circle.");
        }
        else if (z > 5)
        {
            Console.WriteLine("The Point is outside the circle.");
        }
    }
}