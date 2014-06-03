// 04. Write a program that compares two text files line by line and prints the number of lines that are 
// the same and the number of lines that are different. Assume the files have equal number of lines.
using System;
using System.IO;

class CompareLines
{
    static void Main(string[] args)
    {
        Console.Title = "Compare Lines";

        try
        {
            StreamReader textFileOne = new StreamReader(@"..\..\TextFile1.txt");
            StreamReader textFileTwo = new StreamReader(@"..\..\TextFile2.txt");

            Console.WriteLine("Comparing files...");

            using (textFileOne) // open streamwriter
            {
                using (textFileTwo) // open streamreader one
                {
                    int lineNumber = 1;
                    string lineReadOne = string.Empty;
                    string lineReadTwo = string.Empty;
                    int equalLines = 0;
                    int differentLines = 0;

                    while (lineReadOne != null)
                    {
                        lineReadOne = textFileOne.ReadLine(); // reads the next line
                        lineReadTwo = textFileTwo.ReadLine(); // reads the next line

                        if (lineReadOne != null || lineReadTwo != null)
                        {
                            if (lineReadOne == lineReadTwo)
                            {
                                equalLines++;
                            }
                            else
                            {
                                differentLines++;
                            }
                        }
                        
                        lineNumber++; // increment the line counter
                    }
                    Console.Write("Equal lines: {0}\n", equalLines);
                    Console.Write("Different lines: {0}\n", differentLines);
                }
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File {0} is not found!", ex.FileName);
        }
    }
}