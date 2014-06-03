// 06. You are given a sequence of positive integer values written into a string, separated by spaces. 
// Write a function that reads these values from given string and calculates their sum. Example:
//	string = "43 68 9 23 318" -> result = 461

using System;
using System.Linq;

class SequenceIntegersSum
{
    static void Main(string[] args)
    {
        Console.Title = "Sequence Integers Sum";
        Console.Write("Enter a string of positive \nintegers separated by spaces: ");

        int[] numArray = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray(); // splits the entered string at spaces and converts the values to integers

        Console.WriteLine("\nThe sum of all numbers in string is: {0}", numArray.Sum()); // the sum of all elements in the array
    }
}
