// 13. Write a program that reverses the words in given sentence.
//	Example: "C# is not C++, not PHP and not Delphi!" 
//  Output: "Delphi not and PHP, not C++ not is C#!".
// Note: we should keep the punctuation signs in the same order.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ReversedSentence
{
    static void Main(string[] args)
    {
        Console.Title = "Reversed Sentence";
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        string regex = @"\s|,\s*|\.\s*|!\s*"; // punctuation
        List<string> words = new List<string>();
        List<string> punctuations = new List<string>();

        string[] split = Regex.Split(text, regex);
        foreach (string word in split)
        {
            words.Add(word);
        }

        MatchCollection matches = Regex.Matches(text, regex);
        foreach (Match match in matches)
        {
            punctuations.Add(match.Value);
        }

        string temp;
        for (int index = 0; index < matches.Count; index++)
        {
            temp = words[words.Count - 2 - index] + punctuations[index]; // -2 to skip the last word (the empty word)
            Console.Write(temp);
        }
        Console.WriteLine();
    }
}
