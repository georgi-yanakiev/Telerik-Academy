// 02. Write a method GetMax() with two parameters that returns the bigger of two integers. 
// Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class GetMaxValue
{
    static int GetMax(int numOne, int numTwo) // method for getting bigger of 2 numbers
    {
        if (numOne > numTwo)
        {
            return numOne;
        }
        else
        {
            return numTwo;
        }
    }

    static void Main(string[] args)
    {
        Console.Title = "Get Max Value";

        Console.Write("Enter the first number: ");
        int numOne = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int numTwo = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int numThree = int.Parse(Console.ReadLine());

        int biggerOne = GetMax(numOne, numTwo); // invoke the method with the first 2 numbers
        biggerOne = GetMax(biggerOne, numThree); // invoke the method second time with the result of the first call and the third number
        Console.WriteLine("The biggest number of three is {0}.", biggerOne); // printing the result
    }
}
