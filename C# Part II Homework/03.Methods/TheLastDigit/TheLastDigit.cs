// 03. Write a method that returns the last digit of given integer as an 
// English word. Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".

using System;

class TheLastDigit
{
    static string NameTheDigit(int digit) // method for conversion of digit to its name
    {
        string digitToString = null;
        switch (digit)
        {
            case 0:
                digitToString = "zero";
                break;
            case 1:
                digitToString = "one";
                break;
            case 2:
                digitToString = "two";
                break;
            case 3:
                digitToString = "three";
                break;
            case 4:
                digitToString = "four";
                break;
            case 5:
                digitToString = "five";
                break;
            case 6:
                digitToString = "six";
                break;
            case 7:
                digitToString = "seven";
                break;
            case 8:
                digitToString = "eight";
                break;
            case 9:
                digitToString = "nine";
                break;
        }
        return digitToString;
    }
    static void Main(string[] args)
    {
        Console.Title = "The Last Digit";
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        int remainder = 0;
        remainder = number % 10; // dividing to 10 to separate the last digit as a remainder
        Console.WriteLine("The last digit of the number {0} is \"{1}\".", number, NameTheDigit(remainder)); // invoke the method with the remainder
    }
}
