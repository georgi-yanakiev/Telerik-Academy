// 07. Write a method that reverses the digits of 
// given decimal number. Example: 256 -> 652

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class ReversedDigits
{
    static decimal ReversedNumber(decimal num)
    {
        StringBuilder revStr = new StringBuilder();

        string numToString = num.ToString(); // conversion of number to string

        for (int i = numToString.Length - 1; i >= 0; i--) // loop through elements backwards
        {
            revStr.Append(numToString[i]); // append digits in reversed order
        }

        decimal reversed = Convert.ToDecimal(revStr.ToString()); // conversion of reversed string to decimal number
        return reversed;
    }

    static void Main(string[] args)
    {
        Console.Title = "Reversed Digits";
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        Console.Write("Enter a decimal number: ");

        decimal number = decimal.Parse(Console.ReadLine());

        Console.WriteLine("The reversed number is: {0}", ReversedNumber(number)); // invocation of the method and printing the result
    }
}
