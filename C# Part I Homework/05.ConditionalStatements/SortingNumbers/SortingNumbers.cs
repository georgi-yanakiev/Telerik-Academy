// 04.Sort 3 real values in descending 
// order using nested if statements.

using System;

class SortingNumbers
{
    static void Main(string[] args)
    {
        Console.Title = "Sorting Numbers";
        Console.Write("Enter the first number: ");
        int numOne = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int numTwo = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int numThree = int.Parse(Console.ReadLine());

        if (numOne > numTwo)
        {
            if (numOne > numThree)
            {
                if (numTwo > numThree)
                {
                    Console.WriteLine("Sorted numbers: {0}, {1}, {2}", numOne, numTwo, numThree);
                }
                else
                {
                    Console.WriteLine("Sorted numbers: {0}, {1}, {2}", numOne, numThree, numTwo);
                }
            }
            else
            {
                Console.WriteLine("Sorted numbers: {0}, {1}, {2}", numThree, numOne, numTwo);
            }
        }
        else if (numTwo > numThree)
        {
            if (numOne > numThree)
            {
                Console.WriteLine("Sorted numbers: {0}, {1}, {2}", numTwo, numOne, numThree);
            }
            else
            {
                Console.WriteLine("Sorted numbers: {0}, {1}, {2}", numTwo, numThree, numOne);
            }
        }
        else
        {
            Console.WriteLine("Sorted numbers: {0}, {1}, {2}", numThree, numTwo, numOne);
        }
    }
}