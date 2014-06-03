// 08. Write a program that finds the sequence of maximal sum in given array.
// Example:  {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
// Can you do it with only one loop (with single scan through the elements of the array)?

using System;

internal class MaximalArraySequence
{
    private static void Main(string[] args)
    {
        Console.Title = "Maximal Array Sequence";
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());
        var array = new int[n];
        int maxSum = int.MinValue;
        int maxLeft = 0;
        int maxRight = 0;
        int currentMax = 0;
        int left = 0;
        int right = 0;

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter an element: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        // Kadane’s Algorithm used
        for (int q = 0; q < array.Length; q++)
        {
            currentMax += array[q];
            if (currentMax > maxSum)
            {
                maxSum = currentMax; // the maximum sum variable
                right = q;
                maxLeft = left; // the minimum index of the sequence
                maxRight = right; // the maximum index of the sequence
            }
            if (currentMax < 0)
            {
                currentMax = 0;
                left = q + 1;
                right = q + 1;
            }
        }

        Console.Write("The maximal sum is " + maxSum + " -> ");
        Console.Write("{");
        for (int z = maxLeft; z <= maxRight; z++)
        {
            Console.Write(array[z] + ", ");
        }
        Console.WriteLine("\b\b}");
    }
}