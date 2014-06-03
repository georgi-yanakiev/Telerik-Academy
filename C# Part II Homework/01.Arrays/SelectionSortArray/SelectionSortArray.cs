// 07. Sorting an array means to arrange its elements in increasing order. 
// Write a program to sort an array. Use the "selection sort" algorithm: 
// Find the smallest element, move it at the first position, find the smallest 
// from the rest, move it at the second position, etc.

using System;

internal class SelectionSortArray
{
    private static void Main(string[] args)
    {
        Console.Title = "SelectionSortArray";
        Console.Write("Enter the size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int i = 0;
        int j;
        int min = 0;
        int temp = 0;

        for (int k = 0; k < n; k++)
        {
            Console.Write("Enter an element:");
            array[k] = int.Parse(Console.ReadLine());
        }

        for (i = 0; i < array.Length - 1; i++)
        {
            min = i;
            for (j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[min]) // checks if the current element is lesser than the minimal
                {
                    min = j;
                }
            }
            temp = array[i];
            array[i] = array[min]; // switching the places of minimal and currrent elements
            array[min] = temp; 
        }

        foreach (var m in array)
        {
            Console.Write(m+ " ");
        }
        Console.WriteLine();
    }
}