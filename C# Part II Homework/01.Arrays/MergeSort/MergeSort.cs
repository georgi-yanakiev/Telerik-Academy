// 13. * Write a program that sorts an array of integers 
// using the merge sort algorithm (find it in Wikipedia).

using System;

internal class MergeSort
{
    private static int[] Merge(int[] array)
    {
        if (array.Length == 1)
        {
            return array;
        }

        int middle = array.Length/2; // middle index of the array
        int[] left = new int[middle]; // define left array, half the size of the previous (from 0 to [middle] element)

        for (int i = 0; i < middle; i++)
        {
            left[i] = array[i];
        }

        int[] right = new int[array.Length - middle];   // define right array, half the size of the previous (from the [middle] to the last element)

        for (int i = 0; i < array.Length - middle; i++)
        {
            right[i] = array[i + middle];
        }

        left = Merge(left); // recursive call with the left array
        right = Merge(right); // recursive call with the right array

        int leftpointer = 0;
        int rightpointer = 0;

        var sorted = new int[array.Length];
        for (int k = 0; k < array.Length; k++)
        {
            if (rightpointer == right.Length ||
                ((leftpointer < left.Length) && (left[leftpointer] <= right[rightpointer])))
            {
                sorted[k] = left[leftpointer];
                leftpointer++;
            }
            else if (leftpointer == left.Length ||
                     ((rightpointer < right.Length) && (right[rightpointer] <= left[leftpointer])))
            {
                sorted[k] = right[rightpointer];
                rightpointer++;
            }
        }
        return sorted; // returns sorted array
    }

    private static void Main(string[] args)
    {
        Console.Title = "Merge Sort";
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter an element: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int[] result = Merge(array); // calls the method Merge for array sorting

        Console.Write("The sorted array elements are: ");
        foreach (int x in result)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
    }
}