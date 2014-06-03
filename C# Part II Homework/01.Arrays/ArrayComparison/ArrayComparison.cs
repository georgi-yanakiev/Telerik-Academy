// 02. Write a program that reads two arrays from the 
// console and compares them element by element.

using System;

internal class ArrayComparison
{
    private static void Main(string[] args)
    {
        Console.Title = "Array Comparison";
        Console.Write("Enter the size of the first array: ");
        int arrOneSize = int.Parse(Console.ReadLine());
        Console.Write("Enter the size of the second array: ");
        int arrTwoSize = int.Parse(Console.ReadLine());

        int[] arrayOne = new int[arrOneSize];
        int[] arrayTwo = new int[arrTwoSize];
        Console.WriteLine();

        for (int i = 0; i < arrayOne.Length; i++)
        {
            Console.Write("Enter the {0} element of the first array: ", i+1);
            arrayOne[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        for (int i = 0; i < arrayTwo.Length; i++)
        {
            Console.Write("Enter the {0} element of the second array: ", i+1);
            arrayTwo[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        if (arrOneSize != arrTwoSize) // if the sizes are different, the arrays are different
        {
            Console.WriteLine("The arrays are different because of the different size!");
        }
        if (arrOneSize == arrTwoSize)
        {
            for (int j = 0; j < arrayOne.Length; j++)
            {
                if (arrayOne[j] == arrayTwo[j]) // check if the current array elements are equal
                {
                    Console.WriteLine("Elements number {0} from both arrays are equal!", j+1);
                }
                else
                {
                    Console.WriteLine("Elements number {0} from both arrays are different!", j+1);
                }
            }
        }
    }
}