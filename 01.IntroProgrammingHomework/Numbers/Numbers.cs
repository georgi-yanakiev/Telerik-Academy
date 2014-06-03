// Exercise 4: 
// Write a program to print the 
// numbers 1, 101 and 1001.

using System;

class Numbers
{
    static void Main()
    {
        Console.Title = "Printing numbers...";
        // definition of an array called "numbers" containing 3 elements
        int[] numbers = { 1, 101, 1001 };

        // foreach statement repeats a group of embedded statements for each element in the array
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}