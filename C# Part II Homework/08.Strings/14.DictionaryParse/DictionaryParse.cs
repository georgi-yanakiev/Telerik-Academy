// 14. A dictionary is stored as a sequence of text lines containing words and their explanations. 
// Write a program that enters a word and translates it by using the dictionary. Sample dictionary:

using System;
using System.Text.RegularExpressions;

class DictionaryParse
{
    static void Main(string[] args)
    {
        Console.Title = "Dictionary Parse";

        string dictionary = @".NET – platform for applications from Microsoft 
                                CLR – managed execution environment for .NET 
                                namespace – hierarchical organization of classes ";
        string searachWord = ".net";
        string regex = searachWord + @"(\s?)\–(\s?)(?<text>((.|\s)*?)\r)"; // IMPORTANT the following pattern searches only for "–"(dash), not for "-"(minus)
        MatchCollection matches = Regex.Matches(dictionary, regex, RegexOptions.IgnoreCase);

        if (matches.Count > 0)
        {
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups["text"]);
            }
        }
        else
        {
            Console.WriteLine("There is no such word in the dictionary");
        }
    }
}
