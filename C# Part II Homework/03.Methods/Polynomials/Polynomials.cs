// 11. Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
// x2 + 5 = 1x2 + 0x + 5 -> 501
// 12. Extend the program to support also subtraction and multiplication of polynomials.

using System;
using System.Text;

class Polynomials
{
    private static decimal[] Addition(decimal[] polyOne, decimal[] polyTwo) // method for addition of 2 polynomials
    {
        decimal[] newPolynomial = new decimal[Math.Max(polyOne.Length, polyTwo.Length)];

        for (int i = 0; i < polyOne.Length; i++)
        {
            newPolynomial[i] = polyOne[i];
        }

        for (int i = 0; i < polyTwo.Length; i++)
        {
            newPolynomial[i] = newPolynomial[i] + polyTwo[i];
        }

        return newPolynomial;
    }
    private static decimal[] Multiplication(decimal[] polyOne, decimal[] polyTwo) // method for multiplication of 2 polynomials
    {
        decimal[] result = new decimal[polyOne.Length + polyTwo.Length];

        for (int i = 0; i < polyOne.Length; i++)
        {
            for (int y = 0; y < polyTwo.Length; y++)
            {
                result[i + y] = result[i + y] + polyOne[i] * polyTwo[y];
            }
        }

        return result;
    }

    private static decimal[] Subtraction(decimal[] polyOne, decimal[] polyTwo) // method for subtraction of 2 polynomials
    {
        decimal[] newPolynomial = new decimal[Math.Max(polyOne.Length, polyTwo.Length)];

        for (int i = 0; i < polyOne.Length; i++)
        {
            newPolynomial[i] = polyOne[i];
        }

        for (int i = 0; i < polyTwo.Length; i++)
        {
            newPolynomial[i] = newPolynomial[i] - polyTwo[i];
        }

        return newPolynomial;
    }

    private static string PrintFormatting(decimal[] polynomial) // formatting the  results
    {
        StringBuilder resultString = new StringBuilder();

        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            if (polynomial[i] != 0)
            {
                resultString.Append(polynomial[i] > 0 ? " + " : " - ");
                resultString.Append(Math.Abs(polynomial[i]));
                if (i != 0)
                {
                    resultString.Append(i > 1 ? "x^" + i : "x"); // formatting with additional symbols
                }
            }
        }

        if (resultString[1] != '-')
        {
            resultString.Remove(0, 3); // remove initial symbols
        }
        else
        {
            resultString.Remove(0, 1);
        }

        return resultString.ToString();
    }

    static void Main()
    {
        Console.Title = "Polynomials";

        Console.Write("Enter the length of the first polynomial: ");
        int polyOneLen = int.Parse(Console.ReadLine());
        Console.Write("Enter the length of the second polynomial: ");
        int polyTwoLen = int.Parse(Console.ReadLine());

        decimal[] polyOne = new decimal[polyOneLen];
        decimal[] polyTwo = new decimal[polyTwoLen];

        Console.WriteLine();

        for (int i = 0; i < polyOneLen; i++)
        {
            Console.Write("Enter value for polynomial one: ");
            polyOne[i] = decimal.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        for (int i = 0; i < polyTwoLen; i++)
        {
            Console.Write("Enter value for polynomial two: ");
            polyTwo[i] = decimal.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nFirst polynomial:         " + PrintFormatting(polyOne));
        Console.WriteLine("Second polynomial:        " + PrintFormatting(polyTwo));

        decimal[] addition = Addition(polyOne, polyTwo);
        Console.WriteLine("\nResult of addition:       " + PrintFormatting(addition));

        decimal[] subtraction = Subtraction(polyOne, polyTwo);
        Console.WriteLine("Result of subtraction:    " + PrintFormatting(subtraction));

        decimal[] multiplication = Multiplication(polyOne, polyTwo);
        Console.WriteLine("Result of multiplication: " + PrintFormatting(multiplication));
    }
}
