// 08. Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;

class ShortToBinary
{
    static void Main(string[] args)
    {
        Console.Title = "Short To Binary";
        Console.Write("Enter a short number: ");
        short shortNum = short.Parse(Console.ReadLine());
        int tempNum = shortNum;

        if (tempNum < 0)
        {
            tempNum += 65536; // adding 2^16 will make the result number the binary representation of the negative number
        }

        var binary = new List<int>();
        int i = 0;
        int remainder = 0;
        int temp = tempNum;

        do
        {
            remainder = temp % 2; // the remainder of each division 
            temp = temp / 2; // divide the number in 2 untill the result becomes 0
            binary.Add(remainder); // add the remainder values to the list
            i++;
        }
        while (temp > 0);

        binary.Reverse(); // reversing the list to get the binary representation
        Console.WriteLine("The number {0} in binary numeral system is {1}", shortNum, string.Join("", binary));
    }
}