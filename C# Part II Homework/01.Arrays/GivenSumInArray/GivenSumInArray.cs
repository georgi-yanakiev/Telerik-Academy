// 10. Write a program that finds in given array of integers a sequence of given sum S (if present).
// Example:  {4, 3, 1, 4, 2, 5, 8}, S=11 ->  {4, 2, 5}

using System;

internal class GivenSumInArray
{
    private static void Main(string[] args)
    {
        Console.Title = "Given Sum In Array";
        Console.Write("Enter the sum to be found in the array: ");
        int sum = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());
        var array = new int[n];

        for (int q = 0; q < array.Length; q++)
        {
            Console.Write("Enter an element: ");
            array[q] = int.Parse(Console.ReadLine());
        }

        int i = 0;
        int j = 0;
        for (i = 0; i < array.Length; i++)
        {
            int currentSum = array[i]; // initial sum value
            for (j = i + 1; j <= array.Length; j++) // loop through the rest of array's elements
            {
                if (currentSum == sum) // if the sum is met, the result is displayed
                {
                    Console.Write("The sum is found -> {");
                    for (int z = i; z <= j - 1; z++) // loop through indexes to display the sequence of the sum
                    {
                        Console.Write(array[z] + ", ");
                    }
                    Console.WriteLine("\b\b}");
                    return; // if the sum is met, the program exits
                }
                if (currentSum > sum || j == array.Length)
                {
                    break;
                }
                currentSum += array[j];
            }
        }
        Console.WriteLine("The sum can't be found!"); // if the sum is not found in the sequences
    }
}