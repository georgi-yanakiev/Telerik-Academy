// 22. Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Linq;


class WordsInTheString
{
    static void Main()
    {

        Console.Title = "Words In The String";

        // Read
        string input = "The Battle of Stalingrad (August 23, 1942 – February 2, 1943)was a major battle of World War II in which Nazi Germany and its allies fought the Soviet Union for control of the city of Stalingrad (now Volgograd) in the southwestern Soviet Union.";

        // Removes special signs
        string[] specialSigns = 
            {
                ",", ":", ";", "?", "!", "/", "\\", "@", "|", "^", "&", "#", "#", "&", "-", ".", "<", ">", "–", "(", ")", "1", "2", "3", "4", "5", "6", "7", "8", "9", "<", ">"
            };

        for (int index = 0; index < specialSigns.Length; index++)
        {
            input = input.Replace(specialSigns[index], string.Empty);
        }

        // Split the words to array
        string[] wordsArr = input.Split(' ');
        wordsArr = wordsArr.Where(x => !string.IsNullOrEmpty(x)).ToArray();


        // Filling the array
        Dictionary<string, int> words = new Dictionary<string, int>();
        for (int index = 0; index < wordsArr.Length; index++)
        {
            if (words.ContainsKey(wordsArr[index]))
            {
                words[wordsArr[index]]++;
            }
            else
            {
                words.Add(wordsArr[index], 1);
            }
        }

        // Sorting dictionary

        var sortedWords = words.OrderByDescending(x => x.Value);

        // Printing
        foreach (var word in sortedWords)
        {
            Console.WriteLine("The word: {0} is met {1} times", word.Key.PadRight(12), word.Value);
        }
    }
}
