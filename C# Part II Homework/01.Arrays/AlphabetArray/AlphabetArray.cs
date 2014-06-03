// 12. Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.

using System;

internal class AlphabetArray
{
    private static void Main(string[] args)
    {
        Console.Title = "Alphabet Array";

        Console.Write("Enter a word in uppercase (ex: EXAMPLE): ");
        string word = Console.ReadLine();
        int charIndex = 0;
        for (int i = 0; i < word.Length; i++)
        {
            charIndex = word[i] - 64; // defining the index of each letter
            Console.WriteLine("The index of the letter {0} is {1}", word[i], charIndex);
        }
    }
}