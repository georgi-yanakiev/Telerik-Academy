// 05. You are given an array of strings. Write a method that sorts 
// the array by the length of its elements 
// (the number of characters composing them).

using System;

internal class StringSortMethod
{
    private static void Main(string[] args)
    {
        Console.Title = "String Sort Method";
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];
        int[] strLength = new int[n]; // second arrray for keeping the lengths of the strings

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the next string: ");
            array[i] = Console.ReadLine();
            strLength[i] = array[i].Length;  // filling the strings o
        }

        Array.Sort(strLength, array); // using Array.Sort with keys and values. In this case sorting the strings (values) in the array according to their lengths (keys).

        foreach (var word in array)
        {
            Console.WriteLine(word);
        }

    }
}