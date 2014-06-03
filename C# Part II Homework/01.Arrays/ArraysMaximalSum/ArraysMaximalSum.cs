// 06. Write a program that reads two integer numbers
// N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

using System;

internal class ArraysMaximalSum
{
    private static void Main(string[] args)
    {
        Console.Title = "Arrays Maximal Sum";
        Console.Write("Enter the size of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter how many elements to sum: ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int biggestSum = 0;
        int tempSum = 0;
        int sumIndex = 0;
        int tempIndex = 1;

        for (int m = 0; m < n; m++)
        {
            Console.Write("Enter the {0} element: ", m + 1);
            array[m] = int.Parse(Console.ReadLine());
        }

        int j = 0;
        for (int i = 0; i <= n - k; i++)
        {
            for (j = i; j < k + i; j++)
            {
                tempSum += array[j];
            }

            if (tempSum > biggestSum)
            {
                sumIndex = i; // the index of the first element in the sum sequence
                biggestSum = tempSum; // the biggest sum
                tempIndex = j - i;
            }
            tempSum = 0;
        }
        Console.Write("Biggest sum is: {0}", biggestSum);
        Console.Write(" -> {");
        for (int q = sumIndex; q < sumIndex + tempIndex; q++)
        {
            Console.Write(array[q] + ", ");
        }
        Console.WriteLine("\b\b}");
    }
}