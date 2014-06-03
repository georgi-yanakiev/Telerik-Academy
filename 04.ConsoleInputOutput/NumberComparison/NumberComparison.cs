// 05.Write a program that gets two numbers from the console 
// and prints the greater of them. Don’t use if statements.

using System;
using System.Linq;

class NumberComparison
{
    static void Main(string[] args)
    {
        Console.Title = "Number Comparison";
        Console.Write("Enter the first number: ");
        int numOne = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int numTwo = int.Parse(Console.ReadLine());
        int[] numArr = {numOne, numTwo}; // define new array and assign the numbers
        
        Console.WriteLine("The greater number is: " + numArr.Max()); // using Max() method to get the max number in array
    }
}