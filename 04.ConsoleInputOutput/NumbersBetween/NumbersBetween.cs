// 04.Write a program that reads two positive integer numbers and 
// prints how many numbers p exist between them such that the 
// reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class NumbersBetween
{
    static void Main(string[] args)
    {
        Console.Title = "Numbers Between";
        Console.Write("Enter the first number: ");
        uint numOne = uint.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        uint numTwo = uint.Parse(Console.ReadLine());
        int numCount = 0;
        
        if (numOne < numTwo) // checking the bigger number
        {
            for (uint i = numOne; i <= numTwo; i++)
            {
                if (i % 5 == 0) // checking for numbers dividing on 5 without remainder
                {
                    numCount++;
                }
            }
            Console.WriteLine("There are {0} numbers between {1} and {2}.", numCount, numOne, numTwo);
        }
        else
        {
            for (uint i = numTwo; i <= numOne; i++)
            {
                if (i % 5 == 0)
                {
                    numCount++;
                }
            }
            Console.WriteLine("There are {0} numbers between {1} and {2}.", numCount, numTwo, numOne);
        }
    }
}