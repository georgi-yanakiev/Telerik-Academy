// 04. Write methods that calculate the surface of a triangle by given: Side and an altitude to it;
//  Three sides; Two sides and an angle between them. Use System.Math.

using System;

class TriangleSurface
{
    private static double CalcMethodThree(double sideOne, double sideTwo, double angle)
    {
        double degreeToRadians = angle * (Math.PI / 180); // the Math.Sin() uses radians instead of degrees, that's why conversion is needed
        double area = ((sideOne * sideTwo) * Math.Sin(degreeToRadians)) / 2;
        return area;
    }

    private static double CalcMethodTwo(double sideOne, double sideTwo, double sideThree) // Heron's Formula for the area of a triangle
    {
        double halfPerimeter = (sideOne + sideTwo + sideThree) / 2;
        double sqrValue = halfPerimeter * (halfPerimeter - sideOne) * (halfPerimeter - sideTwo) * (halfPerimeter - sideThree); // if 0 or negative, there is no such triangle

        if (sqrValue <= 0)
        {
            Console.WriteLine("\nThe triangle don't exist!");
            System.Environment.Exit(0);
        }

        double area = Math.Sqrt(sqrValue); // the area formula

        return area;
    }

    private static double CalcMethodOne(double triSide, double triAltitude)
    {
        double area = (triSide * triAltitude) / 2; // the area formula
        return area;
    }

    static void Main(string[] args)
    {
        Console.Title = "Triangle Surface";
        Console.WriteLine("Choose method for calculation of the triangle's area: ");
        Console.WriteLine("\"1\" - for calculation by side and altitude.");
        Console.WriteLine("\"2\" - for calculation by three sides.");
        Console.WriteLine("\"3\" - for calculation by two sides and an angle between them.");
        Console.Write("\nEnter your choice: ");
        int methodChoice = int.Parse(Console.ReadLine());

        if (methodChoice == 1)
        {
            Console.Write("Enter value for the side of the triangle: ");
            double triSide = double.Parse(Console.ReadLine());
            Console.Write("Enter value for the altitude of the triangle: ");
            double triAltitude = double.Parse(Console.ReadLine());

            Console.WriteLine("The triangle's area is: {0}", CalcMethodOne(triSide, triAltitude));
        }
        else if (methodChoice == 2)
        {
            Console.Write("Enter value for the first side of the triangle: ");
            double sideOne = double.Parse(Console.ReadLine());
            Console.Write("Enter value for the second side of the triangle: ");
            double sideTwo = double.Parse(Console.ReadLine());
            Console.Write("Enter value for the third side of the triangle: ");
            double sideThree = double.Parse(Console.ReadLine());

            Console.WriteLine("The triangle's area is: {0}", CalcMethodTwo(sideOne, sideTwo, sideThree));
        }
        else if (methodChoice == 3)
        {
            Console.Write("Enter value for the first side of the triangle: ");
            double sideOne = double.Parse(Console.ReadLine());
            Console.Write("Enter value for the second side of the triangle: ");
            double sideTwo = double.Parse(Console.ReadLine());
            Console.Write("Enter value for the third side of the triangle: ");
            double angle = double.Parse(Console.ReadLine());

            Console.WriteLine("The triangle's area is: {0}", CalcMethodThree(sideOne, sideTwo, angle));
        }
        else
        {
            Console.WriteLine("Wrong method chosen! Please try again.");
            return;
        }
    }
}