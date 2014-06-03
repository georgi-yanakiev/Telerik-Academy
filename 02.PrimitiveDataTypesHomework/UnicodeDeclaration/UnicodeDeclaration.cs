// Declare a character variable and assign it with the
// symbol that has Unicode code 72, Hint: first use the
// Windows Calculator to find the hexadecimal 
// representation of 72.

using System;

class UnicodeDeclaration
{
    static void Main(string[] args)
    {
        Console.Title = "Unicode Declaration"; 
        string hex = "\u0048";
        int toChar = 72;
        Console.WriteLine(hex);
        Console.WriteLine((char)toChar);
    }
}