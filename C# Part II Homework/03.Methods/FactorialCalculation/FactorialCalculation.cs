// 10. Write a program to calculate n! for each n in the range [1..100].
// Hint: Implement first a method that multiplies a number represented 
//as array of digits by given integer number.

using System;
using System.Numerics;

internal class FactorialCalculation
{
    private static BigInteger CalculateFactorial(int i)
    {
        BigInteger result = 1;

        for (int j = 1; j <= i; j++) // factorial calculation of each number
        {
            result *= j;
        }

        return result;
    }
    static void Main(string[] args)
    {
        Console.Title = "Factorial Calculation";

        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine("{0}! = {1}", i, CalculateFactorial(i)); // method invocation with numbers from 1 to 100
        }
    }
}
