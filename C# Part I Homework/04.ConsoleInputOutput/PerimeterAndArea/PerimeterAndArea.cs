// 02. Write a program that reads the radius r of a 
// circle and prints its perimeter and area.

using System;

class PerimeterAndArea
{
    static void Main(string[] args)
    {
        Console.Title = "Perimeter And Area";
        Console.Write("Enter circle's radius: ");
        uint r = uint.Parse(Console.ReadLine());
        double area = Math.PI * r * r; // circle's area formula
        double perimeter = 2 * Math.PI * r; // circle's area perimeter
        Console.WriteLine("Circle's area is: {0}", area);
        Console.WriteLine("Circle's perimeter is: {0}", perimeter);
    }
}