// 21.  Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 

using System;
using System.Collections.Generic;
using System.Linq;


class LettersInTheString
{
    static void Main()
    {

        Console.Title = "Letters In The String";

        // Read
        string input = "The Battle of Stalingrad (August 23, 1942 – February 2, 1943)was a major battle of World War II in which Nazi Germany and its allies fought the Soviet Union for control of the city of Stalingrad (now Volgograd) in the southwestern Soviet Union.";

        // Removes special signs
        string[] specialSigns = 
            {
                ",", ":", ";", "?", "!", "/", "\\", "@", "|", "^", "&", "#", "#", "&", " ", "-", ".", "<", ">", "–", "(", ")"
            };

        for (int index = 0; index < specialSigns.Length; index++)
        {
            input = input.Replace(specialSigns[index], string.Empty);
        }

        // Solution
        Dictionary<char, int> letters = new Dictionary<char, int>();

        for (int index = 0; index < input.Length; index++)
        {
            if (letters.ContainsKey(input[index]))
            {
                letters[input[index]]++;
            }
            else
            {
                letters.Add(input[index], 1);
            }
        }

        // Sorting dictionary
        var sortedLetters = letters.OrderByDescending(x => x.Value);
        foreach (var letter in sortedLetters)
        {
            Console.WriteLine("The letter {0} is met {1} times", letter.Key, letter.Value);
        }
    }
}
