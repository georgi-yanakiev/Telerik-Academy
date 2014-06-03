// 06.Write a program that enters the coefficients 
// a, b and c of a quadratic equation a*x² + b*x + c = 0
// and calculates and prints its real roots. 
// Note that quadratic equations may have 0, 1 or 2 real roots.

using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.Title = "Quadratic Equation";
        Console.Write("Enter the a coefficient: ");
        double coefA = double.Parse(Console.ReadLine());
        Console.Write("Enter the b coefficient: ");
        double coefB = double.Parse(Console.ReadLine());
        Console.Write("Enter the c coefficient: ");
        double coefC = double.Parse(Console.ReadLine());
        double discrim = 0;
        double solutionOne = 0;
        double solutionTwo = 0;

        discrim = (coefB * coefB) - (4 * coefA * coefC); // discriminant calculation

        if (discrim == 0) // one solution only
        {
            solutionOne = -coefB / (2 * coefA);
            Console.WriteLine("The solution is {0}.", solutionOne);
        }
        else if (discrim < 0)  // If discriminant is < 0, there is no solution
        {
            Console.WriteLine("There is no solution!");
        }
        else // discriminant > 0  -> 2 solutions
        {
            solutionOne = (-coefB - Math.Sqrt(discrim)) / (2 * coefA);
            solutionTwo = (-coefB + Math.Sqrt(discrim)) / (2 * coefA);
            Console.WriteLine("Solution one is {0}.", solutionOne);
            Console.WriteLine("Solution two is {0}.", solutionTwo);
        }
    }
}