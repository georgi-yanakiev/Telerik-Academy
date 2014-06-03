// 13. Write a program that can solve these tasks:
// Reverses the digits of a number
// Calculates the average of a sequence of integers
// Solves a linear equation a * x + b = 0
//	Create appropriate methods.
//	Provide a simple text-based menu for the user to choose which task to solve.
//	Validate the input data:
// The decimal number should be non-negative
// The sequence should not be empty
// a should not be equal to 0

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class SolveTheTasks
{
    static void Main(string[] args)
    {
        Console.Title = "Solve The Tasks";
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        Console.WriteLine("Choose a task to solve:");
        Console.WriteLine("Enter 1 to reverse a digits of a number.");
        Console.WriteLine("Enter 2 for calculation of average of a sequence of numbers.");
        Console.WriteLine("Enter 3 to solve the linear equation a*x + b = 0.");
        Console.Write("\nYour choice: ");
        byte task = byte.Parse(Console.ReadLine());

        // task choise
        if (task == 1)
        {
            ReversedNumber();
        }
        if (task == 2)
        {
            AverageCalculation();
        }
        if (task == 3)
        {
            SolveEquation();
        }
    }

    // solve equation task
    private static void SolveEquation()
    {
        Console.WriteLine("\"Solve the linear equation a*x + b = 0\"");
        Console.Write("Enter a value for \"a\" (a != 0): ");
        decimal a = decimal.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("\"a\" could not be 0! Try again!");
            return;
        }
        Console.Write("Enter a value for \"b\": ");
        decimal b = decimal.Parse(Console.ReadLine());
        decimal x = 0;
        x = -b / a; // a*x + b = 0 can be presented as a*x = -b -> x = -b/a
        Console.WriteLine("The result for \"x\" is: {0}", x);
    }

    // average calculation task
    private static void AverageCalculation()
    {
        Console.WriteLine("\"Calculation of average of a sequence of numbers\"");
        Console.Write("Enter the count of numbers: ");
        int cnt = int.Parse(Console.ReadLine());
        if (cnt <= 0)
        {
            Console.WriteLine("The sequence cannot be empty or negative! Try again!");
            return;
        }

        decimal[] numArray = new decimal[cnt];

        for (int i = 0; i < cnt; i++)
        {
            Console.Write("Enter a number: ");
            numArray[i] = decimal.Parse(Console.ReadLine());
        }

        decimal sum = 0;

        for (int i = 0; i < cnt; i++) // sum up the elements of the sequence
        {
            sum += numArray[i];
        }

        Console.WriteLine("The average number in the sequence is {0}.", (sum / cnt)); // the result is the sum divided to the number of elements
    }

    // reversed number task
    private static void ReversedNumber()
    {
        Console.WriteLine("\"Reverse the digits of a number\"");
        Console.Write("Enter a positive number: ");
        decimal number = decimal.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("The number must be positive! Try again!");
            return;
        }

        StringBuilder revStr = new StringBuilder();

        string numToString = number.ToString(); // conversion of number to string

        for (int i = numToString.Length - 1; i >= 0; i--) // loop through elements backwards
        {
            revStr.Append(numToString[i]); // append digits in reversed order
        }

        decimal reversed = Convert.ToDecimal(revStr.ToString()); // conversion of reversed string to decimal number
        Console.WriteLine("The reversed number is: {0}", reversed);
    }
}
