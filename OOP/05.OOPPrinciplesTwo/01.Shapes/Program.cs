// 01. Define abstract class Shape with only one abstract method CalculateSurface() 
// and fields width and height. Define two new classes Triangle and Rectangle that 
// implement the virtual method and return the surface of the figure (height*width 
// for rectangle and height*width/2 for triangle). Define class Circle and suitable 
// constructor so that at initialization height must be kept equal to width and implement 
// the CalculateSurface() method. Write a program that tests the behavior of  the CalculateSurface() 
// method for different shapes (Circle, Rectangle, Triangle) stored in an array.

namespace Shapes
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            // array of shapes
            Shape[] figures = new Shape[]
            {
                new Rectangle(2.7,5.4),
                new Triangle(3.1,7.0),
                new Circle(2.44),
            };

            // printing of surface calculations
            foreach (var form in figures)
            {
                Console.WriteLine("The surface of the {0} = {1:F2}", form.GetType().Name, form.CalculateSurface());
            }
        }
    }
}