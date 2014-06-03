// 06. Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

using System;
using System.Collections.Generic;
using System.IO;

class SortedListOfStrings
{
    static void Main(string[] args)
    {
        Console.Title = "Sorted List Of Strings";
        Console.WriteLine("Sorting names...");

        try
        {
            StreamReader inputFile = new StreamReader(@"..\..\UnsortedNamesFile.txt");
            StreamWriter resultFile = new StreamWriter(@"..\..\SortedNamesFile.txt"); // file is located in the project folder

            using (resultFile) // open streamwriter
            {
                using (inputFile) // open streamreader one
                {
                    int lineNumber = 1;
                    string lineRead = string.Empty;
                    List<string> namesList = new List<string>();

                    while (lineRead != null)
                    {
                        lineRead = inputFile.ReadLine(); // reads the next line
                        if (lineRead != null)
                        {
                            namesList.Add(lineRead);
                        }

                        lineNumber++; // increment the line counter
                    }

                    namesList.Sort();

                    for (int name = 0; name < namesList.Count; name++)
                    {
                        resultFile.WriteLine(namesList[name]);
                    }
                }
            }
        }
        catch (System.IO.FileNotFoundException ex)
        {
            Console.WriteLine("File {0} is not found!", ex.FileName);
        }
    }
}
