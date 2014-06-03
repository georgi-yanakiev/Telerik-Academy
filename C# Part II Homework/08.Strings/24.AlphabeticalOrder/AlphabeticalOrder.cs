// 24.Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;

class AlphabeticalOrder
{
    static void Main()
    {
        Console.Title = "AlphabeticalOrder";
        string input = "This is just a string of words that makes no sense at all";
        List<string> listOfWords = new List<string>(input.Split(' '));
        listOfWords.Sort();
        input = string.Join(" ", listOfWords.ToArray());
        Console.WriteLine(input);
    }
}
