// 08. Write an expression that calculates trapezoid's 
// area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main(string[] args)
    {
        double area = 0;

        Console.Write("Enter trapezoid's A side: ");
        double aSide = double.Parse(Console.ReadLine());
        Console.Write("Enter trapezoid's B side: ");
        double bSide = double.Parse(Console.ReadLine());
        Console.Write("Enter trapezoid's height: ");
        double height = double.Parse(Console.ReadLine());

        area = ((aSide + bSide) / 2) * height;      // the formula for trapezoid's area
        Console.WriteLine("The area of the trapezoid is: " + area);
    }
}