// 01. Write a program that allocates array of 20 integers and initializes each 
// element by its index multiplied by 5. Print the obtained array on the console.
 
using System;

internal class ArrayAllocation
{
    private static void Main(string[] args)
    {
        Console.Title = "Array Allocation";
        var array = new int[20];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i*5; 
        }
        foreach (int x in array)
        {
            Console.WriteLine(x);
        }
    }
}