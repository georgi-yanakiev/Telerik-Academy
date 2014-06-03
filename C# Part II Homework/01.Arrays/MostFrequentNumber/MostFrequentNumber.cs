// 09. Write a program that finds the most frequent number in an array.
// Example:     {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)

using System;

internal class MostFrequentNumber
{
    private static void Main(string[] args)
    {
        Console.Title = "Most Frequent Number";

        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];

        for (int q = 0; q < size; q++)
        {
            Console.Write("Enter an array element: ");
            arr[q] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        int[] checkArray = new int[arr[arr.Length - 1] + 1];
        int maxCount = 0;
        int number = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            ++checkArray[arr[i]];
            if (checkArray[arr[i]] > maxCount)
            {
                maxCount = checkArray[arr[i]]; // current biggest count of equal elements
                number = arr[i]; // the most frequent element
            }
        }

        Console.WriteLine("The most frequent number in the array is {0} ({1} times)", number, maxCount);
    }
}