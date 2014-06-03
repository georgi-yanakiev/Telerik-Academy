// Exercise 8: 
// Create a console application that calculates 
// and prints the square of the number 12345.

using System;

class SquareNumbers
{
    static void Main()
    {
        Console.Title = "Square numbers";
        int number = 12345;

        // Solution 1 - Usage of Math.Pow method. First parameter represents the specified number
        // the second parameter is the power that it should be raised
        // + sign is used to concatinate the 2 strings
        Console.WriteLine("The square of the number 12345 is: " + Math.Pow(number, 2));

        // Solution 2 
        //Console.WriteLine("The square of the number 12345 is: " + (number * number));
    }
}