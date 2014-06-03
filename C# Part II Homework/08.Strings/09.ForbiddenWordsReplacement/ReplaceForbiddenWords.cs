// 09. We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that replaces the forbidden words with asterisks.
// Example: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
// Output: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

using System;
using System.Text.RegularExpressions;

class ReplaceForbiddenWords
{
    private static void Main(string[] args)
    {
        Console.Title = "Replace Forbidden Words";
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string input = "PHP,CLR,Microsoft"; // you can just make it read from console in the same format.
        string forbiddenWords = input.Replace(",", "|");
        Console.WriteLine((Regex.Replace(text, forbiddenWords, m => new string('*', m.Length))));
    }
}
