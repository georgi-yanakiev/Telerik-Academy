// 02. Write a program that reads a string, reverses it and prints the result at the console.
// Example: "sample" -> "elpmas".

using System;
using System.Text;

class ReversedString
{
    static void Main(string[] args)
    {
        Console.Title = "Reversed String";
        Console.Write("Enter a string: ");

        string inputString = Console.ReadLine();

        StringBuilder reversedString = new StringBuilder();

        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            reversedString.Append(inputString[i]); // adding string characters in reversed order to the StringBuilder
        }

        Console.WriteLine("Reversed string is: {0}", reversedString);
    }
}
