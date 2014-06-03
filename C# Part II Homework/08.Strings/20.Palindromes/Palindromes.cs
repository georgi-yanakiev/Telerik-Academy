// 20. Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


class Palindromes
{
    static void Main()
    {
        Console.Title = "Palindromes";
        string input = "Some text with palindroms like lamal and exe or ABBA. Does it count for AbBa?";

        // Get all words
        string regex = @"\s+|\,\s*|\;\s*|\:\s*\-\s*|\!\s*|\?\s*|\.\s*";
        string[] wordss = Regex.Split(input, regex, RegexOptions.IgnorePatternWhitespace);
        wordss[wordss.Length - 1] = "notPolindrome";// Replacinsg the last word so it is not null

        // check if palindrome and add to list if True
        List<string> palindrom = new List<string>();
        string temp;
        for (int index = 0; index < wordss.Length; index++)
        {
            temp = wordss[index];
            if (IsPalindrome(temp))
            {
                palindrom.Add(temp);
            }
        }

        // Print
        foreach (string word in palindrom)
        {
            Console.WriteLine(word);
        }
    }
    static bool IsPalindrome(string src)
    {
        bool palindrome = true;

        for (int i = 0; i < src.Length / 2 + 1; i++)
        {
            if (src[i] != src[src.Length - i - 1])
            {
                palindrome = false;
                break;
            }
        }
        return palindrome;
    }
}
