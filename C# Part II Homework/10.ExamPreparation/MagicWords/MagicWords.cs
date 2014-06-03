using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MagicWords
{
    static void Main(string[] args)
    {
        int numOfWords = int.Parse(Console.ReadLine());
        string[] wordArr = new string[numOfWords];
        int longestWord = 0;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < numOfWords; i++)
        {
            wordArr[i] = Console.ReadLine();

            if (wordArr[i].Length > longestWord)
            {
                longestWord = wordArr[i].Length;
            }
        }

        List<string> wordList = wordArr.ToList();

        for (int i = 0; i < numOfWords; i++)
        {
            int index = ((wordList[i].Length % (numOfWords + 1)));
            string temp = wordList[i];
            wordList[i] = string.Empty;
            wordList.Insert(index, temp);
            wordList.Remove(string.Empty);
        }

        string[] wordArrNew = (wordList.ToArray());

        for (int j = 0; j < longestWord; j++)
        {
            for (int i = 0; i < wordArrNew.Length; i++)
            {
                wordArrNew[i] = wordArrNew[i].PadRight(longestWord, '*');
                sb.Append(wordArrNew[i][j]);
            }
        }

        Console.WriteLine(sb.ToString().Replace("*", ""));
    }
}
