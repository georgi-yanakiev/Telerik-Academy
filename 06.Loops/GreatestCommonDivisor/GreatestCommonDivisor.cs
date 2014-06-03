// 08. Write a program that calculates the greatest common divisor (GCD) 
// of given two numbers. Use the Euclidean algorithm (find it in Internet).

using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int numOne = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int numTwo = int.Parse(Console.ReadLine());
        int size = 0;
        int gcd = 0;

        size = Math.Max(numOne, numTwo); // detirmine the bigger number

        for (int i = 1; i <= size; i++)
        {
            if (numOne % i == 0 && numTwo % i == 0) // gcd is the number divisable to both numbers
            {
                gcd = i;
            }
        }
        Console.WriteLine("The GCD of {0} and {1} is: {2}", numOne, numTwo, gcd);
    }
}
