// 13. Write a program that reads a list of words from a file words.txt and finds how many times each of 
// the words is contained in another file test.txt. The result should be written in the file result.txt and the
// words should be sorted by the number of their occurrences in descending order. 
// Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

class CountTheWordOccurrences
{
    static void Main(string[] args)
    {
        Console.Title = "Count The Word Occurances";
        Console.WriteLine("Counting word occurrences...");

        try
        {
            StreamReader inputFile = new StreamReader(@"..\..\Test.txt");
            StreamWriter resultFile = new StreamWriter(@"..\..\Result.txt"); // file is located in the project folder

            using (resultFile)
            {
                using (inputFile)
                {

                    string[] wordsArr = File.ReadAllLines("../../Words.txt"); // put each word from Words.txt file in array
                    int[] wordCounter = new int[wordsArr.Length]; // new array to keep the values of each count

                    for (string ln; (ln = inputFile.ReadLine()) != null; )
                    {
                        for (int i = 0; i < wordsArr.Length; i++)
                        {
                            string pattern = @"\b" + wordsArr[i] + @"\b"; // the pattern changes with each word
                            wordCounter[i] += Regex.Matches(ln, pattern).Count; // count the occurrences of the word
                        }
                    }

                    Array.Sort(wordCounter, wordsArr); // sort by keys and values

                    for (int q = wordsArr.Length - 1; q >= 0; q--)
                    {
                        resultFile.WriteLine("{0} - {1} times", wordsArr[q], wordCounter[q]); // write each line in file in descending order
                    }
                }
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
