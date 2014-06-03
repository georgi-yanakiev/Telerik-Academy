// 06. Write a program that, for a given two 
// integer numbers N and X, calculates the sum
// S = 1 + 1!/X + 2!/X^2 + … + N!/X^N

using System;

class FactorialSumCalculation
{
    static void Main()
    {
        Console.Write("Enter value for N: " );
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value for X: ");
        int x = int.Parse(Console.ReadLine());
        decimal tempX = 1;
        decimal nFactorial = 1;
        decimal sum = 1;

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
            tempX *= x;
            sum += (nFactorial / tempX);
        }
        Console.WriteLine("The sum is {0}",sum);
    }
}
