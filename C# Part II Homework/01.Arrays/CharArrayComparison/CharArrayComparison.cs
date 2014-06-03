// 03. Write a program that compares two 
// char arrays lexicographically (letter by letter).

using System;

internal class CharArrayComparison
{
    private static void Main()
    {
        Console.Title = "Char Array Comparison";
        Console.Write("Enter the first string: ");
        string stringOne = Console.ReadLine();
        Console.Write("Enter the second string: ");
        string stringTwo = Console.ReadLine();
        bool eqFlag = false;  // flag for equality
        int i = 0;
        int j = 0;

        while ((i < stringOne.Length) && (j < stringTwo.Length)) // loop through the elements
        {
            if (stringOne[i] < stringTwo[j]) // check for which character is lexicographically bigger
            {
                Console.WriteLine("Lexicographically {0} is first.", stringOne);
                eqFlag = false;
                break;
            }
            else if (stringOne[i] > stringTwo[j])
            {
                Console.WriteLine("Lexicographically {0} is first.", stringTwo);
                eqFlag = false;
                break;
            }
            else
            {
                eqFlag = true; // if the characters are equal
            }
            i++;
            j++;
        }
        if (eqFlag)
        {
            if (stringOne.Length == stringTwo.Length)
            {
                Console.WriteLine("The strings are equal!");
            }
            else
            {
                string res = (stringOne.Length > stringTwo.Length) ? stringTwo : stringOne;
                Console.WriteLine("Lexicographically {0} is first.", res);
            }
        }
    }
}