// 01. Write a program that reads 3 integer numbers 
// from the console and prints their sum.

using System;

class ThreeIntSum
{
    static void Main(string[] args)
    {
        Console.Title = "Sum of three Integers";
        Console.Write("Enter the first number: ");
        int numOne = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int numTwo = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int numThree = int.Parse(Console.ReadLine());

        Console.WriteLine("The sum of the three numbers is: " + (numOne + numTwo + numThree));
    }
}