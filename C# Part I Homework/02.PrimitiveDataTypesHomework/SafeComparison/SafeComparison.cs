// Write a program that safely compares floating-point
// numbers with precision of 0.000001. Examples:
// (5.3; 6.01) -> false; (5.00000001; 5.00000003) -> true


using System;

class SafeComparison
{
    static void Main(string[] args)
    {
        Console.Title = "Safe Comparison";
        Console.Write("Enter first floating point number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second floating point number: ");
        double b = double.Parse(Console.ReadLine());
        if (Math.Round(a, 6) == Math.Round(b, 6))
        {
            Console.WriteLine("The numbers are equal (True).");
        }
        else
        {
            Console.WriteLine("The numbers are not equal (False).");
        }
    }
}