// 02.Write a program that shows the sign (+ or -) of the product of three
// real numbers without calculating it. Use a sequence of if statements.

using System;

class SignOfTheProduct
{
    static void Main(string[] args)
    {
        Console.Title = "Sign Of The Product";
        Console.Write("Enter the first number: ");
        int numOne = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int numTwo = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int numThree = int.Parse(Console.ReadLine());
        int signCount = 0;

        if (numOne == 0 || numTwo == 0 || numThree == 0)
        {
            Console.WriteLine("The product of the three numbers is 0.");
            Environment.Exit(0);
        }

        if (numOne < 0)
        {
            signCount++;
        }
        if (numTwo < 0)
        {
            signCount++;
        }
        if (numThree < 0)
        {
            signCount++;
        }
        if (signCount == 1 || signCount == 3) // if 1 or 3 of the numbers are negative,  then the product is negative.
        {
            Console.WriteLine("Thе product is negative.");            
        }
        else
        {
            Console.WriteLine("Thе product is positive.");            
        }
    }
}