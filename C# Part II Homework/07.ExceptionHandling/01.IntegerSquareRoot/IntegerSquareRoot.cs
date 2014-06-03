// 01. Write a program that reads an integer number and calculates and prints its square root. 
// If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". 
// Use try-catch-finally.

using System;

class IntegerSquareRoot
{
    static void Main(string[] args)
    {
        Console.Title = "Integer Square Root";
        Console.Write("Enter an integer number: ");

        try
        {
            int number = int.Parse(Console.ReadLine()); // reading the number

            if (number < 0)
            {
                throw new FormatException("Invalid number!"); // throws exception if the number is negative
            }

            double sqrNum = Math.Sqrt(number);
            Console.WriteLine("The square of number {0} is {1}", number, sqrNum);
        }

        catch (FormatException ex) // catch the exception if number is negative
        {
            Console.Error.WriteLine(ex.Message);
        }

        catch (OverflowException) // catch the exception if number is too big or small
        {
            Console.Error.WriteLine("Invalid number!");
        }

        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}
