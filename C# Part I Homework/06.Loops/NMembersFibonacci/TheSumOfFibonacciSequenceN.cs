// 07. Write a program that reads a number N and calculates the sum of the first 
// N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;
using System.Numerics;

class TheSumOfFibonacciSequenceN
{
    static void Main()
    {
        Console.Write("Enter a value for N: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger first = 0;
        BigInteger second = 1;
        BigInteger temp = 0;
        BigInteger total = 0;
     
        for (int i = 0; i < (n - 2); i++)
        {
            temp = first + second;
            first = second;
            second = temp;
            total += temp;
        }
        Console.WriteLine("The sum of the {0} members is {1}", n, (1 + total));
    }
}