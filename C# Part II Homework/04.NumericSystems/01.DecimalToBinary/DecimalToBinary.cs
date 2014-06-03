// 01. Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        Console.Title = "Decimal To Binary";
        Console.Write("Enter a decimal number: ");

        int decNum = int.Parse(Console.ReadLine());
        var binary = new List<int>();
        int i = 0;
        int remainder = 0;
        int temp = decNum;

        do
        {
            remainder = temp % 2; // the remainder of each division 
            temp = temp / 2; // divide the number in 2 untill the result becomes 0
            binary.Add(remainder); // add the remainder values to the list
            i++;
        } while (temp > 0);

        binary.Reverse(); // reversing the list to get the binary representation
        Console.WriteLine("The number {0} in binary numeral system is {1}", decNum, string.Join("", binary));
    }
}
