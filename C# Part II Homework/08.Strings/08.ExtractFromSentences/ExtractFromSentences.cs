// 08. Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Text.RegularExpressions;

internal class ExtractFromSentences
{
    private static void Main(string[] args)
    {
        Console.Title = "Extract From Sentences";
        Console.Write("Enter a string: ");
        string inputText = Console.ReadLine(); // reading the input text
        string[] sentenceArr = Regex.Split(inputText, @"(?<=[\.!\?])\s+"); // split the text in sentences in array
        Console.Write("Enter the word: ");
        string inputWord = Console.ReadLine(); // the word we are looking for
        
        Console.WriteLine();
        for (int i = 0; i < sentenceArr.Length; i++)
        {
            var match = Regex.Match(sentenceArr[i], "\\b" + inputWord + "\\b"); // check if there is a match in the sentences, if do we print it.
            if (match.Success)
            {
                Console.WriteLine(sentenceArr[i]);
            }
        }
        Console.WriteLine();
    }
}