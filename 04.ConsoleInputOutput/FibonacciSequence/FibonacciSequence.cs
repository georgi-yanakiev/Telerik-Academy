// 09.Write a program to print the first 100 members of the sequence 
// of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;
using System.Numerics;

class FibonacciSequence
{
    static void Main()
    {
        Console.Title = "Fibonacci Sequence";
        BigInteger a = 0;
        BigInteger b = 1;

        for (int i = 0; i < 50; i++) // cycle 50 times because printing 2 values at time
        {
            Console.Write(a + ", " + b + ", "); 
            a += b;
            b += a;
        }
        Console.WriteLine("\b\b "); // delete the last "," symbol
    }
}