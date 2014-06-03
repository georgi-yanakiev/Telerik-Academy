// 02. Write a boolean expression that checks for given integer 
// if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class DivisionRemainder
{
    static void Main(string[] args)
    {
        Console.Title = "Division Remainder";
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());

        // If the remainders of both divisions is 0, the number can be divided to both 5 and 7 
        Console.WriteLine(num % 5 == 0 && num % 7 == 0);
    }
}