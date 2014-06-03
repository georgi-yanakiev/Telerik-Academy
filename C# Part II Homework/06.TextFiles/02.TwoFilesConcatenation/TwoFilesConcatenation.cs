// 02. Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class TwoFilesConcatenation
{
    static void Main(string[] args)
    {
        Console.Title = "Two Files Concatenation";

        try
        {
            StreamReader textFileOne = new StreamReader(@"..\..\TextFile1.txt");
            StreamReader textFileTwo = new StreamReader(@"..\..\TextFile2.txt");
            StreamWriter resultFile = new StreamWriter(@"..\..\ResultFile.txt"); // file is located in the project folder

            Console.WriteLine("Merging files...");

            using (resultFile) // open streamwriter
            {
                using (textFileOne) // open streamreader one
                {
                    int lineNumber = 1;
                    string lineRead = string.Empty;

                    while (lineRead != null)
                    {
                        lineRead = textFileOne.ReadLine(); // reads the next line
                        if (lineRead != null)
                        {
                            resultFile.WriteLine(lineRead); // writes the line to the file
                        }

                        lineNumber++; // increment the line counter
                    }
                }
                using (textFileTwo) // open streamreader two
                {
                    int lineNumber = 1;
                    string lineRead = string.Empty;

                    while (lineRead != null)
                    {
                        lineRead = textFileTwo.ReadLine(); // reads the next line
                        if (lineRead != null)
                        {
                            resultFile.WriteLine(lineRead); // writes the line to the file
                        }

                        lineNumber++; // increment the line counter
                    }
                }
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File {0} is not found!", ex.FileName);
        }
    }
}