// 07.Write a program that gets a number n and after that 
// gets more n numbers and calculates and prints their sum. 

using System;
using System.Linq;

class SumOfNumbers
{
    static void Main(string[] args)
    {
        Console.Title = "Sum Of Numbers";
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} more numbers: ", number);

        int[] nNumbers = new int[number]; // define an array with "number" elements
        for (int i = 0; i < number; i++)
        {
            nNumbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum of all numbers is: " + nNumbers.Sum()); // using Sum() method to sum all the elements in the array
    }
}