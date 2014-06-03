// 14. Write a program that sorts an array of strings 
// using the quick sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

internal class QuickSort
{
    private static List<int> QSort(List<int> sortedArray, int left, int right) // definiton of QSort method
    {
        int i = left; // first index
        int j = right; // last index
        double pivotValue = ((left + right)/2); // middle index
        int x = sortedArray[Convert.ToInt32(pivotValue)];

        while (i <= j)
        {
            while (sortedArray[i] < x)
            {
                i++;
            }
            while (x < sortedArray[j])
            {
                j--;
            }
            if (i > j) continue;

            int temp = sortedArray[i];
            sortedArray[i++] = sortedArray[j];
            sortedArray[j--] = temp;
        }
        if (left < j)
        {
            QSort(sortedArray, left, j); // recusive call
        }

        if (i < right)
        {
            QSort(sortedArray, i, right);  // recusive call
        }

        return sortedArray;
    }

    private static void Main(string[] args)
    {
        Console.Title = "Quick Sort";
        List<int> tempData = new List<int>();
        Console.Write("Enter the number of elements in the array: ");

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter an element: ");
            tempData.Add(int.Parse(Console.ReadLine()));
        }

        int left = 0;
        int right = tempData.Count - 1;
        List<int> newList = QSort(tempData, left, right);

        Console.Write("The sorted array is: ");
        foreach (int element in newList)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}

