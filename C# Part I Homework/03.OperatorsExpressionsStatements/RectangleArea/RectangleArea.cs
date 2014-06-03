// 03. Write an expression that calculates rectangle’s 
// area by given width and height.

using System;

class RectangleArea
{
    static void Main(string[] args)
    {
        Console.Title = "Rectangle's Area";
        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("Rectangle's area is {0}.", (height+width)*2); // rectangle's area formula
    }
}
