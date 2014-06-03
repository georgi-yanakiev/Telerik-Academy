// Task 01. "C# Fundamentals 2011/2012 Part 1 - Test Exam" 
using System;

class MathExpression
{
    static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        double res1 = Math.Pow(n, 2);
        double res2 = 1 / (m * p);
        double res3 = n - (128.523123123 * p);
        double res4 = Math.Sin((int)m % 180);

        double final = (((res1 + res2 + 1337) / res3) + res4);
        Console.WriteLine("{0:F6}", final);
    }
}