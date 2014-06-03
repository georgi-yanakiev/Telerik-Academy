using System;

internal class LargestNumInArray
{
    private static void Main(string[] args)
    {
        Console.Title = "LargestNumInArray";
        Console.Write("Enter the number of elements in the array N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a value for K: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();


        Array.Sort(array); // sorting the array

        int elementIndex = Array.BinarySearch(array, k);
        // invokes the method Array.BinarySearch which returns the index of the element K

        if (array[0] > k) // checks if the first (smallest after the sorting) element is bigger than K
        {
            Console.WriteLine("No element is equal or lesser than K in the array!");
        }
        else
        {
            if (elementIndex >= 0)
            {
                Console.WriteLine("The largest number in the array which is <= K is: {0}", array[elementIndex]);
                // number found
            }
            else
            {
                Console.WriteLine("The largest number in the array which is <= K is: {0}", array[~elementIndex - 1]);
                // prints the closest <= K number
            }
        }
    }
}