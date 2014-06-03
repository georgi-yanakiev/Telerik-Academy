// 09. Write a method that return the maximal element in a portion of array of integers starting at given index.
// Using it write another method that sorts an array in ascending / descending order.

using System;

class MaximalElementAndSort
{
    private static int[] SortArray(int[] array, int method)
    {
        int i;
        int j;
        int min;
        int temp;

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

        if (method == 2)
        {
            Array.Reverse(array);
        }
        return array;
    }

    private static int BiggestFromIndex(int[] array, int idx)
    {
        int maxElement = int.MinValue;

        for (int i = idx; i < array.Length; i++) // loops through the elements starting from the index
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i]; // maxElement keeps the biggest value found
            }
        }

        return maxElement;
    }

    static void Main(string[] args)
    {
        Console.Title = "Maximal Element And Sort";
        Console.Write("Enter the number of elements in the array: ");

        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter an index of element (0 <= index < {0}): ", n);
        int idx = int.Parse(Console.ReadLine());

        Console.Write("Enter a method for sort (1 for ascending, 2 for descending): ");
        int method = int.Parse(Console.ReadLine());

        string methStr = (method == 1) ? "ascending" : "descending";

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a number: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nThe biggest element from index {0} is: {1}", idx, BiggestFromIndex(array, idx)); // invokes the method with the array and the index as parameters

        Console.Write("\nThe {0} sorted elements in the array are: ", methStr);
        foreach (var element in SortArray(array, method)) // invokes the method SortArray with array and the method of sorting
        {
            Console.Write(element + ", ");
        }
        Console.WriteLine("\b\b \n");
    }
}
