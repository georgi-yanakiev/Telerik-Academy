// 12. Write a program that removes from a text file all words listed in 
// given another text file. Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

class RemoveTheWordsFromFile
{
    private static void Main(string[] args)
    {
        Console.Title = "Remove The Words From File";

        try
        {
            StreamReader inputFile = new StreamReader(@"..\..\TextFile.txt");

            using (inputFile)
            {
                string workingFile = File.ReadAllText(@"..\..\TextFile.txt");
                string pattern = "\\b(" + string.Join("|", File.ReadAllLines("../../Words.txt")) + ")\\b"; // reads all lines in the file with words and concatenate them with | between

                // the pattern is  \b(word1|word2|word3...)\b - all the words in the pattern will be removed from the file
                File.WriteAllText(@"..\..\Temp.txt", Regex.Replace(workingFile, pattern, string.Empty));

            }

            if (File.Exists(@"..\..\Temp.txt"))
            {
                File.Delete(@"..\..\TextFile.txt"); // removes the original file
                File.Move(@"..\..\Temp.txt", @"..\..\TextFile.txt"); // moves the temp file with the original name
            }

        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }

        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }

        catch (SecurityException ex)
        {
            Console.WriteLine(ex.Message);
        }

        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
