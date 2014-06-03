// 06.Write a program that reads from the console a string of maximum 20 characters. 
// If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
// Print the result string into the console.

using System;

class TwentyCharsString
{
    static void Main(string[] args)
    {
        Console.Title = "Twenty Chars String";
        Console.Write("Enter a string <= 20 characters: ");
        string yourString = Console.ReadLine();
        

        if (yourString.Length <= 20)
        {
            Console.WriteLine("The string you wrote is: \"{0}\"", yourString.PadRight(20, '*')); // if string shorter than 20 we padright with * til length = 20
        }
        else
        {
            Console.WriteLine("The length of your string is bigger than 20 symbols.");
        }
    }
}