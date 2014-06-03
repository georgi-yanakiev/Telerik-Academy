// 05. Write a method that returns the index of the first element in array
// that is bigger than its neighbors, or -1, if there’s no such element.

using System;

class FirstElementIndex
{
    static int GetNeighbours(int[] array, int length)
    {
        for (int i = 0; i < length; i++) // loop through elements 
        {
            if (i < array.Length - 1 && i > 0) // checks if the element is not the first or  the last one
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1]) // checks if the values of the previous and the next element is smaller than the current
                {
                    return i; // returns the index of the element
                }
            }
        }
        return -1; // if no element is bigger than its neighbors then returns -1.
    }

    static void Main(string[] args)
    {
        Console.Title = "First Element Index";
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a number: ");
            array[i] = int.Parse(Console.ReadLine()); // filling the array with values
        }
        int index = GetNeighbours(array, n); // invocation of the method with the array and its length as parameters
        Console.WriteLine("The element index is {0}.", index);
    }
}
