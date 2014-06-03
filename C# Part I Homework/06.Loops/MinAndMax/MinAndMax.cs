// 03.Write a program that reads from the console a sequence of
// N integer numbers and returns the minimal and maximal of them.


using System;

class MinAndMax
{
    static void Main(string[] args)
    {
        Console.Title = "Min And Max";
        Console.Write("Enter a number N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter N more numbers: ");
        int[] arr = new int[n] ;

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine()); // an array with all the values
        }
        Array.Sort(arr); // sorting array
        Console.WriteLine("The minimal number is: {0}.", (arr[0])); // the minimal number is the first element of the array
        Console.WriteLine("The maximal number is: {0}.", (arr[n-1])); // the maximal is the last one
    }
}