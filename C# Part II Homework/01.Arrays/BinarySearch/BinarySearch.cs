// 11. Write a program that finds the index of given element in a sorted array
// of integers by using the binary search algorithm (find it in Wikipedia).

using System;

internal class BinarySearch
{
    private static void Main(string[] args)
    {
        Console.Title = "Binary Search";
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());
        var array = new int[n];
        Console.Write("Enter the element from the array: ");
        int value = int.Parse(Console.ReadLine());

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter an element: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array); // array sort

        int low = 0; // lowest item index
        int high = array.Length - 1; // highest item index

        while (low <= high)
        {
            int midpoint = low + (high - low)/2; // middle index in sorted array

            if (value == array[midpoint]) // checks for equal item in the array
            {
                Console.WriteLine("The index of the element is : {0}.", midpoint);
                return;
            }
            if (value < array[midpoint])
            {
                high = midpoint - 1;
            }
            else
            {
                low = midpoint + 1;
            }
        }
        Console.WriteLine("Element not found in the array!");
    }
}