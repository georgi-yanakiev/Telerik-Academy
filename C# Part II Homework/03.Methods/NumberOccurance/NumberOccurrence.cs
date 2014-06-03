// 04. Write a method that counts how many times given number appears in given array. 
// Write a test program to check if the method is working correctly.

using System;
using System.Collections.Generic;
using System.Linq;

class NumberOccurrence
{
    static int CountOccurrence(List<int> list, int element)
    {
        int counter = 0;
        for (int i = 0; i < list.Count; i++) // checks how many times the element occurs in the list
        {
            if (list[i] == element)
            {
                counter++;
            }
        }
        return counter;
    }
    static void Main(string[] args)
    {
        Console.Title = "Number Occurrence";
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        List<int> origList = new List<int>(); // list of elements

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a number: ");
            origList.Add(int.Parse(Console.ReadLine())); // filling the list
        }

        List<int> distinctList = origList.Distinct().ToList(); // another list, which contains only the distinct values of origList

        foreach (int x in distinctList) // loop through the distinct elements
        {
            Console.WriteLine("The number {0} has {1} occurrences.", x, CountOccurrence(origList, x)); // invoke the method with each of the elements and the original list
        }

    }
}
