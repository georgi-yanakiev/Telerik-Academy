// 01.Write an if statement that examines two integer variables and
// exchanges their values if the first one is greater than the second one.

using System;

class ValueExchange
{
    static void Main(string[] args)
    {
        Console.Title = "Value Exchange";
        Console.Write("Enter the first number: ");
        int numOne = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int numTwo = int.Parse(Console.ReadLine());
        int numTemp = 0; // temp variable for value exchange

        if (numOne < numTwo)
        {
            Console.WriteLine("The first number is: {0}", numOne);
            Console.WriteLine("The second number is: {0}", numTwo);
        }
        else if (numOne > numTwo)
        {
            numTemp = numOne;
            numOne = numTwo;
            numTwo = numTemp;
            Console.WriteLine("The first number is bigger than the second.");
            Console.WriteLine("Switching numbers...");
            Console.WriteLine("The first number is: {0}", numOne);
            Console.WriteLine("The second number is: {0}", numTwo);
        }
        else
        {
            Console.WriteLine("The numbers are equal.");
        }
    }
}